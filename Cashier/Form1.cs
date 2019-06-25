using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        abstract class CashSuper
        {
            public abstract double acceptCash(double money);
        }

        //正常收费
        class CashNorml : CashSuper
        {
            public override double acceptCash(double money)
            {
                return money;
            }
        }

        //打折收费
        class CashRebate : CashSuper
        {
            private double moneyRebate = 1d;

            public CashRebate(string moneyRebate)
            {
                this.moneyRebate = double.Parse(moneyRebate);
            }

            public override double acceptCash(double money)
            {
                return money * moneyRebate;
            }
        }

        //返利收费
        class CashReturn : CashSuper
        {
            private double moneyCondition = 0.0d;
            private double moneyReturn = 0.0d;

            public CashReturn(string moneyCondition, string moneyReturn)
            {
                this.moneyCondition = double.Parse(moneyCondition);
                this.moneyReturn = double.Parse(moneyReturn);
            }

            public override double acceptCash(double money)
            {
                double result = money;
                if (money >= moneyCondition)
                {
                    result = money - Math.Floor(money / moneyCondition) * moneyReturn;
                }

                return result;
            }
        }

        class CashContext
        {
            private CashSuper cs = null;

            public CashContext(string type)
            {
                switch(type)
                {
                    case "正常收费":
                        CashNorml cs0 = new CashNorml();
                        cs = cs0;
                        break;
                    case "满300返100":
                        CashReturn cs1 = new CashReturn("300","100");
                        cs = cs1;
                        break;
                    case "打8折":
                        CashRebate cs2 = new CashRebate("0.8");
                        cs = cs2;
                        break;
                }
            }

            public double GetResult(double money)
            {
                return cs.acceptCash(money);
            }
        }

        private double total = 0.0d;
        private void bt_count_Click(object sender, EventArgs e)
        {
            CashContext csuper = new CashContext(cbx_Type.SelectedItem.ToString());
            double totalPrices = 0d;

            totalPrices = csuper.GetResult(Convert.ToDouble(tb_Price.Text) * Convert.ToDouble(tb_Num.Text));

            total = total + totalPrices;
            lbx_List.Items.Add("单价：" + tb_Price.Text + "数量：" + tb_Num.Text + " " +cbx_Type.SelectedItem + "合计：" + totalPrices.ToString());

            cb_Result.Text = total.ToString();
        }
    }
}

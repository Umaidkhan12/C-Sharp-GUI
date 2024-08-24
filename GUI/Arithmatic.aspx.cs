using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUI
{
    public partial class Arithmatic : System.Web.UI.Page
    {
        Label input1Lb, input2Lb, resultLb;
        TextBox input1Tb, input2Tb, resultTb;
        Button add,sub,mul,div;
        protected void Page_Load(object sender, EventArgs e)
        {
            input1Lb = new Label() { Text = "Number 1" };
            input2Lb = new Label() { Text = "Number 2" };
            resultLb = new Label() { Text = "Result" };

            input1Tb = new TextBox();
            input2Tb = new TextBox();
            resultTb = new TextBox() { ReadOnly = true};

            add = new Button() { Text = "Additon" };
            sub = new Button() { Text = "Subraction" };
            mul = new Button() { Text = "Multiplication" };
            div = new Button() { Text = "Divition" };

            add.Click += new EventHandler(AddNumber);
            sub.Click += new EventHandler(SubNumber);
            mul.Click += new EventHandler(MulNumber);
            div.Click += new EventHandler(DivNumber);

            form1.Controls.Add(input1Lb);
            form1.Controls.Add(input1Tb);
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(input2Lb);
            form1.Controls.Add(input2Tb);
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(resultLb);
            form1.Controls.Add(resultTb);
            form1.Controls.Add(new LiteralControl("<br /><br />"));
            form1.Controls.Add(add);
            form1.Controls.Add(sub);
            form1.Controls.Add(mul);
            form1.Controls.Add(div);
        }

        private void DivNumber(object sender, EventArgs e)
        {
            resultTb.Text = (Convert.ToDecimal(input1Tb.Text) / Convert.ToDecimal(input2Tb.Text)).ToString();
        }

        private void MulNumber(object sender, EventArgs e)
        {
            resultTb.Text = (Convert.ToDecimal(input1Tb.Text) * Convert.ToDecimal(input2Tb.Text)).ToString();
        }

        private void SubNumber(object sender, EventArgs e)
        {
            resultTb.Text = (Convert.ToDecimal(input1Tb.Text) - Convert.ToDecimal(input2Tb.Text)).ToString();
        }

        private void AddNumber(object sender, EventArgs e)
        {
            resultTb.Text = (Convert.ToDecimal(input1Tb.Text) + Convert.ToDecimal(input2Tb.Text)).ToString();
        }
    }
}
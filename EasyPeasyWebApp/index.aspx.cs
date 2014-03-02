using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyPeasyWebApp
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Calc calc = new Calc();
            int a = 0;
            int b = 0;

            if(int.TryParse(txtA.Text, out a))
            {
                if(int.TryParse(txtB.Text, out b))
                {
                    enumOp op = (enumOp)Enum.Parse(typeof(enumOp), ddlOp.SelectedValue);
                    switch(op)
                    {
                        case enumOp.Add:
                            litResult.Text = calc.Add(a, b).ToString();
                            break;
                        case enumOp.Sub:
                            litResult.Text = calc.Sub(a, b).ToString();
                            break;
                        case enumOp.Mul:
                            litResult.Text = calc.Mul(a, b).ToString();
                            break;
                        case enumOp.Div:
                            litResult.Text = calc.Div(a, b).ToString();
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
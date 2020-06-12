using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class HomePage : System.Web.UI.Page
    {
        List<string> nameList=new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            if (ViewState["Name"] != null)
            {
                nameList =(List<string>) ViewState["Name"];
            }
            nameList.Add(name);
            ViewState["Name"] = nameList.ToString();
        }

        protected void showButton_Click(object sender, EventArgs e)
        {

        }
    }
}
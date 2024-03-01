using Demo_ASPFrom.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo_ASPFrom
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                BindData();
            }
        }

       
        public void BindData()
        {
            Registration obj = new Registration();
            grvRegistration.DataSource = obj.Load_RegList();
            grvRegistration.DataBind();
        }

        public void DeleteData(int id)
        {
            Registration obj = new Registration();
            string file = obj.Delete(id);

            File.Delete(Server.MapPath("Doc" + "\\" + file));
        }


        protected void grvRegistration_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            string Command = Convert.ToString(e.CommandName);
            DeleteData(index);
           // GridViewRow gvRow = grvRegistration.Rows[index];
        }


    }
}
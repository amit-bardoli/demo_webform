using Demo_ASPFrom.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo_ASPFrom
{
    public partial class Reg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                BindCity();
                if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
                {
                    int id = Convert.ToInt32(Request.QueryString["ID"]);
                    hfId.Value = id.ToString();
                    BindReg(id);
                }
            }
        }

        private void BindCity()
        {
            Registration obj = new Registration();
            ddlCity.DataSource = obj.Load_CityList();
            ddlCity.DataValueField = "id";
            ddlCity.DataTextField = "name";
            ddlCity.DataBind();
            ddlCity.Items.Insert(0, new ListItem("select", "0"));
        }

        private void BindReg(int id)
        {
            Registration obj = new Registration();
            DataSet ds = obj.GetById(id);
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtName.Text = Convert.ToString(ds.Tables[0].Rows[0]["Name"]);
                txtPassword.Text = Convert.ToString(ds.Tables[0].Rows[0]["Password"]);
                ddlCity.SelectedValue = Convert.ToString(ds.Tables[0].Rows[0]["City"]);
                rblGender.SelectedValue = Convert.ToString(ds.Tables[0].Rows[0]["Gender"]);
                txtEmail.Text = Convert.ToString(ds.Tables[0].Rows[0]["Email"]);
                chkStatus.Checked = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"]) == 1 ? true : false;
                txtSalary.Text = Convert.ToString(ds.Tables[0].Rows[0]["Salary"]);
                txtBirthdate.Text = Convert.ToString(ds.Tables[0].Rows[0]["Birthdate"]);
                hfImage.Value = Convert.ToString(ds.Tables[0].Rows[0]["Image"]);
            }


        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string FN = "";
            int result = 0;
            if (fuImage.HasFile)
            {
                FN = DateTime.Now.Ticks.ToString() + Path.GetFileName(fuImage.PostedFile.FileName);
                fuImage.SaveAs(Server.MapPath("Doc" + "\\" + FN));

                if(hfImage.Value != "")
                {
                    File.Delete(Server.MapPath("Doc" + "\\" + hfImage));
                }
            }
            else
            {
                FN = hfImage.Value;
            }
            Registration obj = new Registration();
            if (hfId.Value != "")
            {
                result = obj.Update(Convert.ToInt32(hfId.Value),txtName.Text, txtPassword.Text, Convert.ToInt32(ddlCity.SelectedValue), rblGender.SelectedValue, txtEmail.Text, FN, Convert.ToInt32(chkStatus.Checked), Convert.ToDecimal(txtSalary.Text), Convert.ToDateTime(txtBirthdate.Text));
            }
            else
            {
                result = obj.Save(txtName.Text, txtPassword.Text, Convert.ToInt32(ddlCity.SelectedValue), rblGender.SelectedValue, txtEmail.Text, FN, Convert.ToInt32(chkStatus.Checked), Convert.ToDecimal(txtSalary.Text), Convert.ToDateTime(txtBirthdate.Text));
            }
            if (result > 0)
            {
                txtName.Text = "";
                txtPassword.Text = "";
                ddlCity.SelectedValue = "0";
                rblGender.ClearSelection();
                txtEmail.Text = "";
                chkStatus.Checked = false;
                txtSalary.Text = "";
                txtBirthdate.Text = "";

                if (hfId.Value != "")
                {
                    lblmsg.Text = "Record updated successfully";
                    hfId.Value = "";
                    hfImage.Value = "";
                }
                else
                    lblmsg.Text = "Record added successfully";
            }


        }
    }
}
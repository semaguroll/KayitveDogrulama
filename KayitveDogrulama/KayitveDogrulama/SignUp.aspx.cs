using KayitveDogrulama.DBData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace KayitveDogrulama
{
    public partial class SignUp : System.Web.UI.Page
    {
        UserData data = new UserData();
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime birthdate = Convert.ToDateTime(txtBirthDate.Text);
                bool realUser = data.TCNoControl(Convert.ToInt64(txtTCNo.Text), txtName.Text, txtSurname.Text, birthdate);
                if (realUser == true)
                {
                    data.SqlAdd(Convert.ToInt64(txtTCNo.Text), txtName.Text, txtSurname.Text, birthdate);
                    Response.Redirect("Result.aspx");

                }
                else
                    MessageBox.Show("Bilgilerinizi kontrol edip tekrar deneyiniz.");

            }
            catch (Exception)
            {

                MessageBox.Show("Bilgilerinizin eksik olup olmadığını kontrol edip tekrar deneyiniz.");
            }

        }

    }
}
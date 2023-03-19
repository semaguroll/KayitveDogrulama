﻿using KayitveDogrulama.DBData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
			DateTime birthdate = Convert.ToDateTime(txtBirthDate.Text);
			bool realUser = data.TCNoControl(Convert.ToInt64(txtTCNo.Text), txtName.Text, txtSurname.Text, birthdate);
			if (realUser)
				data.SqlAdd(Convert.ToInt64(txtTCNo.Text), txtName.Text, txtSurname.Text, birthdate);
            else
            {
				//
            }
			Response.Redirect("Result.aspx");
		}
	}
}
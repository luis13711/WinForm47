﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCsharp
{
    public partial class wfrmCapturaGet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"] != null)

            {

                Response.Write("fname : " + Request.QueryString["ID"] + "\n");

            }
        }
    }
}
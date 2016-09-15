using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace comp229_lesson_2 {
  public partial class Main : System.Web.UI.MasterPage {
    protected void Page_Load(object sender, EventArgs e) {

      Debug.WriteLine("Title is: " + Page.Title);

      fixActiveLinks();
    }

    private void fixActiveLinks() {

      HtmlGenericControl field = null;

      if (Page.Title.ToLower() == "home") {
        field = home;
      }

      if (field != null) {
        field.Attributes.Add("class", "active");
      }
    }
  }
}
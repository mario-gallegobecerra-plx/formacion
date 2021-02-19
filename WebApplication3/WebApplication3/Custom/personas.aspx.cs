using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3.Custom
{
    public partial class personas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public List<Personas> Get_Personas()
        {

            Personas.LoadPersonas();

            return Personas.personas;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CRUDMahasiswaADO
{
    internal class DAL
    {

        static string connectionString = "Data Source=LAPTOP-2QET043V\\DIMAS;Initial Catalog=DBAkademikADO;User ID=sa;Password=Slamet454";

        public string GetConnectionString()
        {
            
            return connectionString;
        }

    }
}
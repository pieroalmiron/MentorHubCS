using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace MentorHub.DbManager
{
    public class DBManagerMSSQL : DBManager
    {
        internal DBManagerMSSQL() : base(LeerConfiguracion().GetConnectionString("mssql"))
        {

        }

        protected override DbConnection CrearConexion()
        {
            return new SqlConnection(CadenaConexion);
        }
    }
}

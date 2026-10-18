using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace MentorHub.DbManager
{
    public class DBManagerMySql : DBManager
    {
        internal DBManagerMySql() : base(LeerConfiguracion().GetConnectionString("mysql"))
        {

        }

        protected override DbConnection CrearConexion()
        {
            return new MySqlConnection(CadenaConexion);
        }
    }
}

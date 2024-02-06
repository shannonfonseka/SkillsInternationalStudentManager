using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SkillsInternationalStudentManager
{

    internal class classPublicVariables
    {
        public static SqlConnection varSqlConnectionString = new SqlConnection(@"Data Source=MARIE-DELL-PC;Initial Catalog=db_SkillsStudentManager;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ZDRJC2
{
    class queryClass
    {
        string strcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "\\JCR.accdb";
        public List<string> getTrack(string sql)
        {
            List<string> list = new List<string>();
            using (OleDbConnection conn = new OleDbConnection(strcon))
            {
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader myReader = comm.ExecuteReader();
                while (myReader.Read())
                {
                    list.Add(myReader[0].ToString());
                }
                return list;
            }
        }
    }
}

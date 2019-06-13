using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO_QLCP;
using DAL_QLCP;

namespace BUS_QLCP
{
    public class MonBO
    {
        DBAccess db = new DBAccess();
        public DataTable getMaMon()
        {
            string query = "Select MaMon from tblDSMon";
            return db.getDS(query);
        }
    }
}

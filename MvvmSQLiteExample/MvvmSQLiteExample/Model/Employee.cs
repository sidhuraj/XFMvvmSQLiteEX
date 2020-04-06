using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MvvmSQLiteExample.Model
{
    public class Employee
    {
        [PrimaryKey,AutoIncrement]
        public int Emplid { set; get; }
        public string Emplname{ set; get; }
        public string EmplAddress { set; get; }


    }
}

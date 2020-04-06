using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLitePCL;

namespace MvvmSQLiteExample.ViewModel
{
     public interface ISqliteConnection
    {
        SQLiteConnection GetConnection();

    }
}

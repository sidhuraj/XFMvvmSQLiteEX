using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmSQLiteExample.Droid;
using MvvmSQLiteExample.ViewModel;
using SQLite;
using Xamarin.Forms;

[assembly:Dependency(typeof(SQliteImplement))]
namespace MvvmSQLiteExample.Droid
{
    public class SQliteImplement : ISqliteConnection
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "Emplyee.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            var sqlitConnection = new SQLiteConnection(path);
            return sqlitConnection;


        }
    }
}
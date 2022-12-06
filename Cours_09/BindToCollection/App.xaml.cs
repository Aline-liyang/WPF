using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BindToCollection
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static StoreDb storeDb = new StoreDb();
        public static StoreDb StoreDb
        {
            get { return storeDb; }
        }

        private static StoreDbDataSet storeDbDataSet = new StoreDbDataSet();
        public static StoreDbDataSet StoreDbDataSet
        {
            get { return storeDbDataSet; }
        }
    }
}

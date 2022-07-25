using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GPUPreferences.Services
{
    public class Checker
    {
        public static void CheckDel(DataGrid data)
        {
            Pref pref = new Pref();
            if (data.Columns[0].Header.ToString() == pref.Address.ToString())
            {
                //foreach(DataGridRow row in data.)
                //{

                //}
            }
        }
    }
}

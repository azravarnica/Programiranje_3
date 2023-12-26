using FIT.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.WinForms.Helpers
{
    public static class Ekstenzije
    {
        public static bool IsSet(this string sadrzaj)
        {
            return !string.IsNullOrWhiteSpace(sadrzaj);
        }
        public static void LoadData<T>(this ComboBox comboBox, List<T> dataSource,
                                       string displayMember = "Naziv", string valueMember = "Id")
        {

            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }
    }
}

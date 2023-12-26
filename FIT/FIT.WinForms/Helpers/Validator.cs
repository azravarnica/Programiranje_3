using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.WinForms.Helpers
{
    public class Validator
    {
        public static bool ProvjeriUnos(Control kontrola, ErrorProvider err, string name)
        {
            bool validanUnos = true;
            if (kontrola is PictureBox && (kontrola as PictureBox).Image == null)
                validanUnos = false;
            else if (kontrola is ComboBox && (kontrola as ComboBox).SelectedIndex < 0)
                validanUnos = false;
            else if (kontrola is TextBox && !(kontrola as TextBox).Text.IsSet())
                validanUnos = false;

            if (!validanUnos)
            {
                err.SetError(kontrola, Resursi.Get(name));
                return false;
            }
            err.Clear();
            return true;

          //  if (!textBox.Text.IsSet())
          // {
          //  err.SetError(textBox, name); return false;
          // }
        }
    }
}

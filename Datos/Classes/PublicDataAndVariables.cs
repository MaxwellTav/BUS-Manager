using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos.Classes
{
    public class PublicDataAndVariables
    {
        #region DebugLog-Output
        public string
            DebugLogPathFile = Application.StartupPath + @"\Logs",
            DebugLogNameFile = "DebugLogOutput " + System.DateTime.Now.ToString("ss mm hh dd MM yyyy");
        #endregion
    }
}

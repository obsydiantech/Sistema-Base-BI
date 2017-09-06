using System.Windows.Forms;

using Sistema_Base_BI.Forms;
using Sistema_Base_BI.Managers;

namespace Sistema_Base_BI
{
    public class Main
    {

        public Main(Form form)
        {
            FormsManager.Instance.Init(form);
        }
    }
}

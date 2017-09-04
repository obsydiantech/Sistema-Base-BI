using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Sistema_Base_BI.Forms.MainForms;

namespace Sistema_Base_BI.Managers
{
    public class FormsManager
    {
        // |------------------------------------ATRIBUTES---------------------------------------------| 
        static FormsManager instance;
        public static FormsManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new FormsManager();

                return instance;
            }
        }
        public List<Form> Forms;

        // |-----------------------------------CONSTRUCTOR--------------------------------------------|

        FormsManager()
        {
            Forms = new List<Form>();
        }

        // |--------------------------------METHODS-FUNCTIONS-----------------------------------------|

        public Boolean Init(Form form)
        {
            Forms.Add(form);
            return true;
        }

        /* Es llamado al momento de necesitar mostrar
         * un nuevo form.
         * Crea ocn Activator, agrega a la lista de forms 
         * y bloquea la form anterior.
         * 
         * Invisible lo deja visible false, sino enabled false
         * */
        public Form NewForm(String FullFormName, Boolean invisible, params object[] parameters)
        {
            try
            {
                Form form = (Form)Activator.CreateInstance(Type.GetType("Sistema_Base_BI.Forms." + FullFormName), parameters);
                Forms.Add(form);

                if (Forms.Count >= 2)
                {
                    if (invisible)
                        Forms[Forms.Count - 2].Visible = false;
                    else
                        Forms[Forms.Count - 2].Enabled = false;
                }

                Forms[Forms.Count - 1].Show();
                Forms[Forms.Count - 1].BringToFront();

                return form;
            }
            catch (Exception e)
            {
                ExceptionManager.Instance.CatchException(e, "Error al mostrar una nueva ventana. Contacte al programador.");
                return null;
            }
        }

        /* Quita de la lista el form removido
         * y desbloquea el último form para su uso.
         * */
        public void PrevForm()
        {
            
            if (Forms.Count - 1 > 0)
            {
                Forms.RemoveAt(Forms.Count - 1);
                Forms[Forms.Count - 1].Enabled = true;
                Forms[Forms.Count - 1].BringToFront();
            }

            else
                Application.Exit();
        }

        public Form ActualForm()
        {
            return Forms[Forms.Count - 1];
        }

        // |------------------------------SERVICE METHODS/FUNCTIONS-----------------------------------|

        // |-------------------------------------EVENTS-----------------------------------------------|
    }
}

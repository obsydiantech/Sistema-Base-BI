using System.ComponentModel;

using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace Sistema_Base_BI.Forms
{
    public static class Personalization
    {
        //What is your style
        private const MetroColorStyle formStyle = MetroColorStyle.Purple;
        private const MetroThemeStyle formTheme = MetroThemeStyle.Dark;

        public static void SetStyle(this IContainer container, MetroForm ownerForm)
        {
            if (container == null)
                container = new Container();

            MetroStyleManager manager = new MetroStyleManager(container);
            manager.Owner = ownerForm;
            container.SetDefaultStyle(ownerForm, formStyle);
            container.SetDefaultTheme(ownerForm, formTheme);
        }
        public static void SetDefaultStyle(this IContainer contr, MetroForm owner, MetroColorStyle style)
        {
            MetroStyleManager manager = FindManager(contr, owner);
            manager.Style = style;
            owner.Style = style;
        }

        public static void SetDefaultTheme(this IContainer contr, MetroForm owner, MetroThemeStyle thme)
        {
            MetroStyleManager manager = FindManager(contr, owner);
            manager.Theme = thme;
            owner.Theme = thme;
        }

        private static MetroStyleManager FindManager(IContainer contr, MetroForm owner)
        {
            MetroStyleManager manager = null;
            foreach (IComponent item in contr.Components)
            {
                if (((MetroStyleManager)item).Owner == owner)
                    manager = (MetroStyleManager)item;
            }
            return manager;
        }
    }
}

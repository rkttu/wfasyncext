using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace System.Windows.Forms
{
    public static class FormActivator
    {
        public static Thread StartModalForm<TForm>(Func<TForm> configurator, IWin32Window parent)
            where TForm : Form
        {
            Thread t = new Thread(() =>
            {
                TForm form = default(TForm);
                if (configurator != null)
                    form = configurator.Invoke();
                if (form == default(TForm))
                    form = Activator.CreateInstance<TForm>();
                form.ShowDialog(parent);
            });
            t.Start();
            return t;
        }

        public static Thread StartModalForm<TForm>(Func<TForm> configurator)
            where TForm : Form
        { return StartModalForm<TForm>(configurator, null); }

        public static Thread StartModalForm<TForm>(IWin32Window parent)
            where TForm : Form
        { return StartModalForm<TForm>(null, parent); }

        public static Thread StartModalForm<TForm>()
            where TForm : Form
        { return StartModalForm<TForm>(null, null); }

        public static Thread StartApp<TForm>(Func<TForm> configurator)
            where TForm : Form
        {
            Thread t = new Thread(() =>
            {
                TForm form = default(TForm);
                if (configurator != null)
                    form = configurator.Invoke();
                if (form == default(TForm))
                {
                    Application.OleRequired();
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    form = Activator.CreateInstance<TForm>();
                }
                Application.Run(form);
            });
            t.Start();
            return t;
        }

        public static Thread StartApp<TForm>()
            where TForm : Form
        { return StartApp<TForm>(null); }

        public static Thread StartAppContext<TAppContext>(Func<TAppContext> configurator)
            where TAppContext : ApplicationContext
        {
            Thread t = new Thread(() =>
            {
                TAppContext appContext = default(TAppContext);
                if (configurator != null)
                    appContext = configurator.Invoke();
                if (appContext == default(TAppContext))
                {
                    Application.OleRequired();
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    appContext = Activator.CreateInstance(typeof(TAppContext), new Form()) as TAppContext;
                }
                Application.Run(appContext);
            });
            t.Start();
            return t;
        }

        public static Thread StartAppContext<TAppContext>()
            where TAppContext : ApplicationContext
        { return StartAppContext<TAppContext>(null); }
    }
}

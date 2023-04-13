using System;
using System.Windows.Forms;

namespace Pracownicy
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var view = new View.Form1();
            var model = new Model.MainModel();
            var presenter = new Presenter.MainPresenter(view, model);
            Application.Run(view);
        }
    }
}

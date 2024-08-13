using OperacionesBasicas.Views;
namespace OperacionesBasicas
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();


            Routing.RegisterRoute(nameof(MainView), typeof(MainView));
        }
    }
}

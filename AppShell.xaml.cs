namespace TreeniApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //reitti Goals sivulle, mahdollistaa navigaation
            Routing.RegisterRoute("Goals", typeof(GoalsPage));
            //reitti lisätietoihin
            Routing.RegisterRoute("Lisatieto", typeof(LisatietoPage));
        }
    }
}

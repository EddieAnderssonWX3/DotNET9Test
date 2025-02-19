namespace DotNET9Test
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        public AppShell myAppShell { get; set; }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            myAppShell = new AppShell();
            return new Window(myAppShell);
        }
    }
}
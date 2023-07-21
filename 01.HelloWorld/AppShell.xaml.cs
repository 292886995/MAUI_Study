namespace _01.HelloWorld;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(Notes.Views.NotePage), typeof(Notes.Views.NotePage));
    }
}

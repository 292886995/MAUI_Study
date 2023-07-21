namespace _01.Hello_World
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            Button navigateHello = new Button
            {
                Text = "Hello!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            navigateHello.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new HelloXamlPage());
            };

            Button navigateXamlPlus = new Button
            {
                Text = "XamlPlus!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            navigateXamlPlus.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new XamlPlusCodePage());
            };

            Button navigateGrid = new Button
            {
                Text = "Grid Demo",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            navigateGrid.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new GridDemoPage());
            };

            Button navigatePlatform = new Button
            {
                Text = "Platform",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            navigatePlatform.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new PlatformPage());
            };

            Button navigateResources = new Button
            {
                Text = "Resources",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            navigateResources.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new ResourcesPage());
            };

            Button navigateBinding = new Button
            {
                Text = "Binding",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            navigateBinding.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new BindingPage());
            };


            layout.Add(navigateHello);
            layout.Add(navigateXamlPlus);
            layout.Add(navigateGrid);
            layout.Add(navigatePlatform);
            layout.Add(navigateResources);
            layout.Add(navigateBinding);
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}
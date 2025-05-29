using System.Collections.ObjectModel;

namespace GridScroller;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
        this.gsDates.Items = new ObservableCollection<UIElement>
        {
            new CheckBox { Content = "2025-05-12" },
            new CheckBox { Content = "2025-05-13" },
            new CheckBox { Content = "2025-05-14" },
            new Button { Content = "A" },
            new Button { Content = "B" }
        };
        this.ChangeBackgroundColor();
    }

    private async void ChangeBackgroundColor()
    {
        // Change the background color of the grid scroller
        //gsDates.Background = new SolidColorBrush(Microsoft.UI.Colors.LightBlue);
        await Task.Delay(5000); // 5 seconds delay
        gsDates.Background = new SolidColorBrush(Microsoft.UI.Colors.White);
    }
}

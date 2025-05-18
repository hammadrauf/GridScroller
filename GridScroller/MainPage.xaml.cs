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
    }
}

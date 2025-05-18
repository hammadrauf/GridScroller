using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace GridScroller;
public sealed partial class cmpGridScroller : UserControl
{
    public static readonly DependencyProperty CornerRadiusProperty =
    DependencyProperty.Register(
        nameof(CornerRadius),
        typeof(CornerRadius),
        typeof(cmpGridScroller),
        new PropertyMetadata(new CornerRadius(5))
    );

    public CornerRadius CornerRadius
    {
        get => (CornerRadius)GetValue(CornerRadiusProperty);
        set => SetValue(CornerRadiusProperty, value);
    }


    private ObservableCollection<UIElement> _items = new();
    public ObservableCollection<UIElement> Items
    {
        get => _items;
        set
        {
            if (_items != value)
            {
                _items = value;
                if (PART_ItemsHost != null)
                    PART_ItemsHost.ItemsSource = _items;
            }
        }
    }


    public static readonly DependencyProperty BorderBrushProperty =
        DependencyProperty.Register(
            nameof(BorderBrush),
            typeof(Brush),
            typeof(cmpGridScroller),
            new PropertyMetadata(new SolidColorBrush(Microsoft.UI.Colors.Brown))
        );

    public Brush BorderBrush
    {
        get => (Brush)GetValue(BorderBrushProperty);
        set => SetValue(BorderBrushProperty, value);
    }

    public static readonly DependencyProperty BorderThicknessProperty =
        DependencyProperty.Register(
            nameof(BorderThickness),
            typeof(Thickness),
            typeof(cmpGridScroller),
            new PropertyMetadata(new Thickness(1))
        );

    public Thickness BorderThickness
    {
        get => (Thickness)GetValue(BorderThicknessProperty);
        set => SetValue(BorderThicknessProperty, value);
    }
    public cmpGridScroller()
    {
        this.InitializeComponent();
        PART_ItemsHost.ItemsSource = Items;
    }
}

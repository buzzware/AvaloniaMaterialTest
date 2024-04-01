using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Input;

namespace AvaloniaMaterialTest.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    private void InputElement_OnTapped(object? sender, TappedEventArgs e) {
        autoComplete.IsDropDownOpen = !autoComplete.IsDropDownOpen;
    }

    private void Icon_OnTapped(object? sender, TappedEventArgs e) {
        Debug.WriteLine("Icon_OnTapped");
    }
}

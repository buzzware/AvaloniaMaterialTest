using System.Collections.Generic;

namespace AvaloniaMaterialTest.ViewModels;

public class MainViewModel : ViewModelBase
{
    private bool _isDropDownOpen;
#pragma warning disable CA1822 // Mark members as static
    public string Greeting => "Welcome to Avalonia!";
    
#pragma warning restore CA1822 // Mark members as static
    
    public List<string> Values { get; } = new List<string>() {
        "one one one one one one one one one one one one one one ", 
        "two two two two two two two two two two two two two two two two two two ", 
        "three three three three three three three three three three three three three three three three three three "
    };

}

using Avalonia.Controls;

namespace Nxa.Avalonia.Router;

public sealed class Router
{
    private List<Router> Children { get; set; }
    public event Action<Control>? NavigationChanged;

    public void Map(
        string path,
        Func<Control> pageFactory,
        Func<bool>? canNavigate = null)
    {
        Routes.Add(path,new Route(path,pageFactory,canNavigate));
    }

    public void NavigateTo(string url)
    {
        
        // Match route
        // Check canNavigate
        // Create page
        // Update current page
        // Emit NavigationChanged
    }

    private Dictionary<string, Route> Routes { get; } = new();
}
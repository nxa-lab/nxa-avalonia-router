using Avalonia.Controls;

namespace Nxa.Avalonia.Router;

public sealed class Route
{
    public string Path { get; }
    public Func<Control> PageFactory { get; }
    public Func<bool>? CanNavigate { get; }

    public Route(
        string path,
        Func<Control> pageFactory,
        Func<bool>? canNavigate = null)
    {
        Path = path;
        PageFactory = pageFactory;
        CanNavigate = canNavigate;
    }
}
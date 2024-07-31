namespace Benday.ConfigOptionsDemo.Api;

public class RootConfiguration
{
    public string SiteName { get; set; } = "Default Site Name";

    public ChildConfiguration Child { get; set; } = new();
    public AnotherChildConfiguration AnotherChild { get; set; } = new();

}

using Benday.ConfigOptionsDemo.Api;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Benday.ConfigOptionsDemo.WebUi.Controllers;

public class OptionsController : Controller
{
    private readonly RootConfiguration _RootConfiguration;

    public OptionsController(IOptions<RootConfiguration> options)
    {
        _RootConfiguration = options.Value;
    }

    public IActionResult Index()
    {
        return View(_RootConfiguration);
    }
}

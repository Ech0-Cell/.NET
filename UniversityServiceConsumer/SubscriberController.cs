namespace UniversityServiceConsumer;

public class SubscriberController : Controller
{
    private readonly AOMService _aomService;

    public SubscriberController(AOMService aomService)
    {
        _aomService = aomService;
    }

    public async Task<IActionResult> CreateSubscriber(Subscriber subscriber)
    {
        await _aomService.CreateSubscriberAsync(subscriber);
        return RedirectToAction("Index", "Home");
    }

    public async Task<IActionResult> ShowRemainingBalances()
    {
        List<Balance> balances = await _aomService.GetRemainingBalancesAsync();
        return View(balances);
    }
}

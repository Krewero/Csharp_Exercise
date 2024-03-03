using Microsoft.AspNetCore.Mvc;

public class BankController : Controller
{
    [Route("/")]
    public IActionResult Index()
    {
        Response.StatusCode = 200;
        return Content("<h1> Welcome to the best bank</h1>", "text/html");
    }

    [Route("/account-details")]
    public JsonResult GetDetails()
    {
        var accountDetails = new
        {
            accountNumber = 1001,
            accountHolderName = "Example Name",
            currentBalance = 5000
        };
        Response.StatusCode = 200;
        return Json(accountDetails);
    }

    [Route("/account-statement")]
    public FileResult DummyPDF()
    {
        return File(@"\DummyPDF.pdf", "application/pdf");
    }

    [Route("/get-current-balance/{accountNumber:int?}")]
    public IActionResult GetBalance()
    {
        var accountDetails = new
        {
            accountNumber = 1001,
            accountHolderName = "Example Name",
            currentBalance = 5000
        };

        bool value = Request.RouteValues.TryGetValue("accountNumber", out var accountNumber);
        if(value == false)
        {
            return NotFound("Account Number should be supplied");
        }
        else if(int.TryParse(accountNumber.ToString(),out int parseAccNum) && parseAccNum != 1001)
        {
            return BadRequest("Account Number should be 1001");
        }
        else
        {
            return Ok(accountDetails.currentBalance.ToString());
        }
    }
}
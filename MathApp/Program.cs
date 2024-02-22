using System.Web;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) =>
{
    int firstNumber, secondNumber, result;
    string operation;

    if(context.Request.Method == "GET" && context.Request.Path == "/")
    {
        firstNumber = ConvertTheQueryString("firstNumber", context);
        secondNumber = ConvertTheQueryString("secondNumber", context);

        operation = context.Request.Query["operation"];

        switch(operation)
        {
            case "+":
            {
                result = firstNumber + secondNumber;
                break;
            }
            case "-":
            {
                result = firstNumber - secondNumber;
                break;
            }
            case "*":
            {
                result = firstNumber * secondNumber;
                break;
            }
            case "/":
            {
                result = firstNumber / secondNumber;
                break;
            }
            case "%":
            {
                result = firstNumber % secondNumber;
                break;
            }
            default:
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsync("This operator doesn't exist");
                break;
            }
        }
    }
    else
    {
        await context.Response.WriteAsync("Waiting for the GET method...");
    }

});



static int ConvertTheQueryString(string queryString, HttpContext context)
{
    if(context.Request.Query.ContainsKey(queryString))
        {
            string firstStringNumber = context.Request.Query[queryString];
            bool parsing = int.TryParse(firstStringNumber, out int convertedNumber);
            return convertedNumber;
        }
        else
        {
            context.Response.StatusCode = 400;
            return 0;
        }
}


app.Run();

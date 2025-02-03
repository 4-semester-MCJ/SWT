var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// The code is set up for 
//http://127.0.0.1:5155/add?a=2&b=3
// ALT you can use 
//app.MapGet("/add/{a}/{b}", (int a, int b) => $"The sum of {a} and {b} is: {a + b}");
// and the URL will be 
//http://127.0.0.1:5155/add/2/3


double Add(double a, double b){
    return a + b; 
}

double Subtract(double a, double b){
    return a - b; 
}

double Multiply(double a, double b){
    return a * b; 
}

double Power(double x, double exp){
    return Math.Pow(x, exp);
}


app.MapGet("/add", (double a, double b) => {
    double result = Add(a,b); 
    return Results.Ok($"The sum of {a} and {b} is: {result}");
}); 


app.MapGet("/Subtract", (double a, double b) => {
    double result = Subtract(a,b);
    return Results.Ok($"The subtracted value of {a} and {b} is: {result}");
});


app.MapGet("/Multiply", (double a, double b) => {
    double result = Multiply(a,b); 
    return Results.Ok($"The value {a} and {b} multiplied together is {result}");
}); 


app.MapGet("/Power", (double x, double exp) => {
    double result = Power(x,exp);
    return Results.Ok($"{x} to the power of {exp} is {result}"); 
});


app.MapGet("/", () => "This is a calculator");

app.Run();

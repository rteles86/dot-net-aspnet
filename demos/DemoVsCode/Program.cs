
//Configuração Builder

using DemoVsCode;
//Responsavel por construir uma instancia asp.net com todas configurações definidas
var builder = WebApplication.CreateBuilder(args);

//Configuração do Pipeline
builder.AddSerilog();

builder.Services.AddControllersWithViews();

//Services

//COnfiguração da App

//Instancia que representa a aplicação e todas as configuracoes dos middlewares
var app = builder.Build();

//Middlewares
app.UseLogTempo();

//COnfiguração de comportamentos da App

app.MapGet("/", () => "Hello World Teles!");
app.MapGet("/teste", () => {
    Thread.Sleep(1500);
    return "Teste 2";
});

app.Run();

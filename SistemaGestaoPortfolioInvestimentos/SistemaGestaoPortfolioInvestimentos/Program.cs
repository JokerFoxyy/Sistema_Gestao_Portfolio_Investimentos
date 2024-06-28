using Microsoft.EntityFrameworkCore;
using SistemaGestaoPortfolioInvestimentos.DAO;
using SistemaGestaoPortfolioInvestimentos.Data;
using SistemaGestaoPortfolioInvestimentos.Interfaces;
using SistemaGestaoPortfolioInvestimentos.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Configure Entity Framework and In-Memory Database
builder.Services.AddDbContext<DataBaseContext>(options =>
    options.UseInMemoryDatabase("InvestmentPortfolioDB"));

// Register repositories and services
builder.Services.AddScoped<IProductDAO, ProductDAO>();
builder.Services.AddScoped<IInvestmentDAO, InvestmentDAO>();

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IInvestmentService, InvestmentService>();

builder.Services.AddScoped<EmailService>(provider =>
    new EmailService("smtp.gmail.com", 587, "email@gmail.com", "password"));

builder.Services.AddScoped<NotificationService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

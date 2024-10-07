using FluentValidation.AspNetCore;
using FluentValidation;
using SumApi;
using SumApi.Interfaces;
using SumApi.Services;
using SumApi.Validators;
using SumApi.Extensions;
using System.Reflection;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();

        var assembly = Assembly.GetExecutingAssembly();
        builder.Services.AddServices(assembly);
        builder.Services.AddValidators(assembly);

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}
using Senario01.Data.Context;
using Microsoft.EntityFrameworkCore;
using Senario01.Ioc;
using FluentValidation;
using Senario01.Domain.Utilities.Fluent;
using Senario01.Domain.Entities;
using Microsoft.OpenApi.Models;
using FluentValidation.AspNetCore;
using System;
using Senario01.Domain.Dtos;
using Senario01.Application.Utilities.FluentValidation;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddDbContext<Senario01DbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);
builder.Services.AddAutoMapper(typeof(Program))
    ;builder.Services.AddControllers()
                .AddFluentValidation(options =>
                {
                    // Validate child properties and root collection elements
                    options.ImplicitlyValidateChildProperties = true;
                    options.ImplicitlyValidateRootCollectionElements = true;
                    // Automatic registration of validators in assembly
                    options.RegisterValidatorsFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());
                });

builder.Services.AddDependencies();
builder.Services.AddSwaggerGen();

builder.Services.AddEndpointsApiExplorer();


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

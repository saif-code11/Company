using CampanySystem.Data;
using CampanySystem.Genaricrepo;
using CampanySystem.Work;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using CampanySystem.Map;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
var config = new ConfigurationManager();
var hours = config["Jwt:ExpireHoure"];
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbcontext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("Name")));
builder.Services.AddScoped(typeof(IgenaricRepo<>) , typeof(GenaricRepo<>));
builder.Services.AddScoped<Iunitofwork, UnitofWork>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddAuthentication(
    o =>
    {
        o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    }

    ).AddJwtBearer(
    e => new TokenValidationParameters 
    {
        
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateIssuerSigningKey = true,

        ValidIssuer = config["Jwt:Issuer"],
        ValidAudience = config["Jwt:Audince"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Jwt:Key")),
        RequireExpirationTime = true,
    
         
    }
    );
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.UseAuthorization();

app.MapControllers();

app.Run();

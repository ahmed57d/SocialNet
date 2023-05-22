using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SocialNet.Repository.Contexts;
using SocialNet.Repository;
using SocialNet.Service.IService;
using SocialNet.Service;
using SocialNet.Repository.IRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//var connectionString = builder.Configuration.GetConnectionString("AppDbContext");


//builder.Services.AddDbContextFactory<AppDbContext>(options => options.UseSqlServer("AppDbContext"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMvc();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("AppDbContext")));
builder.Services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
builder.Services.AddScoped(typeof(IPostRepository), typeof(PostRepository));
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IPostService, PostService>();

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

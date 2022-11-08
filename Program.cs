global using QuestionAPP.Models;
using QuestionAPP.Data;
using Microsoft.EntityFrameworkCore;
using QuestionAPP.Service.UserService;
using QuestionAPP.Service.QuestionService;
using QuestionAPP.Controllers;
using QuestionAPP.Service.AnswerService;
using QuestionAPP.Service.UserAnswerService;
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      builder =>
                      {
                          builder.WithOrigins("http://localhost:3000/questions",
                                              "http://localhost:3000").AllowAnyHeader()
                                                                      .AllowAnyMethod()
                                                                      .AllowCredentials();
                      });
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IQuestionService, QuestionService>();
builder.Services.AddScoped<IAnswerService, AnswerService>();
builder.Services.AddScoped<IUserAnswerService, UserAnswerService>();

var app = builder.Build();
app.UseCors(MyAllowSpecificOrigins);
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}


app.UseAuthorization();
app.MapControllers();

app.Run();

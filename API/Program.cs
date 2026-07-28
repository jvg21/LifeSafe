using API.Data;
using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;


Env.Load();

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddOpenApi();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});


#region DataBaseConnection

//Console.WriteLine(builder.Configuration.GetConnectionString("DefaultConnection"));

var ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DBContext>(option => option.UseSqlServer(ConnectionString));
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();

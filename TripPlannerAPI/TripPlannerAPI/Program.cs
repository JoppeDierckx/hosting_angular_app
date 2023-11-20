using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using TripPlannerDAL;
using TripPlannerDAL.Initializer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add your database configuration
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<TripPlannerDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("TripReadAccess", policy => policy.RequireClaim("permissions", "read:trip"));
    options.AddPolicy("TripWriteAccess", policy => policy.RequireClaim("permissions", "create:trip", "update:trip"));
    options.AddPolicy("TripDeleteAccess", policy => policy.RequireClaim("permissions", "delete:trip"));
});

builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Your API",
        Version = "v1"
    });
});

builder.Services.AddCors(options =>
<<<<<<< HEAD
{
=======
    {
>>>>>>> 06d8a3f4b940cb12b7cf32f9f14ea01b30ae72c9
    options.AddDefaultPolicy(builder =>
        builder.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod());
<<<<<<< HEAD
}
=======
    }
>>>>>>> 06d8a3f4b940cb12b7cf32f9f14ea01b30ae72c9
);


var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var applicationContext = scope.ServiceProvider.GetRequiredService<TripPlannerDbContext>();
    DBInitializer.Initialize(applicationContext);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors();

app.MapControllers();

app.Run();
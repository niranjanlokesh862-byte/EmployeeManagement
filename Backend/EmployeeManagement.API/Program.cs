using EmployeeManagement.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add controller support
builder.Services.AddControllers();

builder.Services.AddScoped<IEmployeeService, EmployeeService>();

// Add OpenAPI generation
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    // Generate OpenAPI document
    app.MapOpenApi();

    // Swagger UI
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "Employee Management API v1");
    });
}

app.UseHttpsRedirection();

// Map controller routes
app.MapControllers();

app.Run();
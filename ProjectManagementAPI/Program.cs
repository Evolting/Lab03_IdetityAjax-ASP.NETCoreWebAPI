var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

/* 
 * Cross-Origin Resource Sharing (CORS) is an HTTP-header based mechanism
 * that allows a server to indicate any origins (domain, scheme, or port)
 * other than its own from which a browser should permit loading resources. 
 */
builder.Services.AddCors();

builder.Services.AddControllers();
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

app.UseCors(builder =>
{
    builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
});

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();

// From: https://khalidabuhakmeh.com/speed-up-aspnet-core-json-apis-with-source-generators

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("person", () => Results.Json(new TestRecord("Khalid", Friend: new Address(1, "A road")),
                           TestRecordSerializationContext.Default.Options))
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();

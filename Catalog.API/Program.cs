var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddControllers();

app.MapGet("/", () => "Hello World!");

app.Run();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();
app.UseStaticFiles();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
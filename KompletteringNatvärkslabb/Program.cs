WebApplication app = WebApplication.Create(args);

app.UseHttpsRedirection();

app.MapGet("/", Hejmicke);

app.Run();

static string Hejmicke()
{
    return "Hej micke kolla vilken cool labb, eller hur?";
}
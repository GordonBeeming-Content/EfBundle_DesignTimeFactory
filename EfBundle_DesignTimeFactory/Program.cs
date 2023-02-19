var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<LocalDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

Console.WriteLine($"location: {Assembly.GetExecutingAssembly().Location}");
var extraConfigFilePath =
  Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!,
  "extra-config.json");
// do something with extraConfigFilePath

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

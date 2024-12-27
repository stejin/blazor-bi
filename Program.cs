using blazor_bi;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using SqliteWasmHelper;
using blazor_bi.Data;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = ":memory:" };
//var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "sample-data/chinook.db" };
//var connection = new SqliteConnection(connectionStringBuilder.ToString());

builder.Services.AddSqliteWasmDbContextFactory<ThingContext>(
  opts => opts.UseSqlite("Data Source=http://localhost:5120/sample-data/chinook.db"));

await builder.Build().RunAsync();

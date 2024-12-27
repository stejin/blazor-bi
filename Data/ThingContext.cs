using Microsoft.EntityFrameworkCore;

namespace blazor_bi.Data
{
    public class ThingContext : DbContext
    {
        public ThingContext(DbContextOptions<ThingContext> opts) : base(opts)
        {
            /*try
            {
                FormattableString sql = $"SELECT count(*) from invoices";
                var r = this.Database.ExecuteSql(sql);
                Things.Add(new Thing { Id = r, Name = "InvoiceCount" });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }*/
        }

        public DbSet<Thing> Things { get; set; } = null!;
    }
}
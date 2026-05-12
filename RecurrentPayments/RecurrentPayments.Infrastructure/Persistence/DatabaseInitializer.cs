namespace RecurrentPayments.Infrastructure.Persistence;

public static class DatabaseInitializer
{
    public static void Initialize(AppDbContext context)
    {
        context.Database.EnsureCreated();
    }
}
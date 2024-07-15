namespace Store.Domain.Seeds
{
    public abstract class BaseSeed
    {
        protected AppDbContext Context { get; private set; }
        public abstract void Seed();

        public BaseSeed(AppDbContext context)
        {
            Context = context;
        }
    }
}

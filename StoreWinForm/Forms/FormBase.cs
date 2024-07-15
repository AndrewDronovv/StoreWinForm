using Store.Domain;

namespace StoreWinForm.Forms
{
    public class FormBase : Form
    {
        protected IServiceProvider ServiceProvider { get; set; }
        protected AppDbContext Context { get; set; }

        public FormBase(IServiceProvider serviceProvider, AppDbContext context)
        {
            ServiceProvider = serviceProvider;
            Context = context;
        }

        public FormBase()
        {
        }
    }
}

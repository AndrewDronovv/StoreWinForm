namespace Store.Domain.Entities
{
    public class Category : Entity
    {
        //TODO: сделать в будущем required
        public string Name { get; set; }

        public Category(string name)
        {
            Name = name;
        }
    }
}

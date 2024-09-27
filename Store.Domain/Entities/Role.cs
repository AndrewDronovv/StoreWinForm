namespace Store.Domain.Entities
{
    public class Role : Entity
    {
        //TODO: сделать в будущем required
        public string Name { get; set; }

        public Role(string name)
        {
            Name = name;
        }
    }
}

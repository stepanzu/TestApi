namespace TestApi.Models
{
    public abstract class Animal
    {
        public Animal() 
        {
            this.Id = 1;
            this.Name = "Bichu";
        }

        public abstract string CojerColorAnimal();

        public abstract string CojerColorAnimal(int il);

        public int TestHola() 
        {
            return 0;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}

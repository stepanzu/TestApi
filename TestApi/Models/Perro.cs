namespace TestApi.Models
{
    public class Perro : Animal
    {
        public Perro() : base()
        {
            base.Name = "Tatiana";

        }
        public int Patas { get; set; }

        public override string CojerColorAnimal()
        {
            throw new NotImplementedException();
        }

        public override string CojerColorAnimal(int il)
        {
            throw new NotImplementedException();
        }


        public int TestHola() 
        {
            //return 8;
            //return base.TestHola();
            return base.TestHola() * 12;
        }
    }
}

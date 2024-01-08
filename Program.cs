namespace zoo_animals
{


    abstract class Creature
    {
        protected virtual string? Name { get; }
        protected virtual int? Weight { get; }

        public override string ToString()
        {
            return $"\tName: {Name}\n\tWeight: {Weight}";
        }

    }

    internal class Animal : Creature
    {
        protected string? Realm { get => "Animal"; }

        public override string ToString()
        {
            return base.ToString() + $"\n\tRealm: {Realm}";
        }
    }

    internal class Reptile : Animal
    {
        protected string? Type { get => "Reptile"; }
        public override string ToString()
        {
            return base.ToString() + $"\n\tType: {Type}";
        }
    }

    internal class Mammal : Animal
    {
        protected string? Type { get => "Mammal"; }
        public override string ToString()
        {
            return base.ToString() + $"\n\tType: {Type}";
        }
    }

    internal class Bird : Animal
    {
        protected string? Type { get => "Bird"; }
        public override string ToString()
        {
            return base.ToString() + $"\n\tType: {Type}";
        }
    }
    internal class Fish : Animal
    {
        protected string? Type { get => "Fish"; }
        public override string ToString()
        {
            return base.ToString() + $"\n\tType: {Type}";
        }
    }

    internal class Bear : Mammal
    {
        protected override string? Name => "Bear";
        protected override int? Weight => 250;
    }

    internal class Frog : Reptile
    {
        protected override string? Name => "Frog";
        protected override int? Weight => 1;
    }

    internal class Dolphin : Mammal
    {
        protected override string? Name => "Dolphin";
        protected override int? Weight => 500;
    }

    internal class Carp : Fish
    {
        protected override string? Name => "Carp";
        protected override int? Weight => 2;
    }

    internal class Eagle : Bird
    {
        protected override string? Name => "Eagle";

        protected override int? Weight => 5;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Creature[] zoo = new Animal[] {
                new Bear(),
                new Carp(),
                new Eagle(),
                new Dolphin(),
                new Frog()
            };
            foreach (var item in zoo)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
        }
    }
}
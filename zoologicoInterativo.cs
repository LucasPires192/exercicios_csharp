using System;

class Program
{
    static void Main()
    {
        List<Animal> animais =  new List<Animal>
        {
            new Gato("bichano", "gato", "mia"),
            new Cachorro("Tótó", "cachorro", "late"),
            new Vaca("Mimosa", "vaca", "mugi"),
            new Leao("Alex", "leao", "ruge"),
            new Galinha("Ginger", "galinha", "cacareja"),
            new Ganco("Paulo", "ganco", "grasna"),
            new Sapo("Principe", "sapo", "coaxa"),
            new Andorinha("Dorite", "andorinha", "grifa")
        };

        Console.WriteLine("Digite uma raça de animal para procurar:");

        string entrada = (Console.ReadLine()??"").ToLower();

        SomAnimal(animais, entrada);
    }
    abstract class Animal
    {
        public string nome;
        private string raca;
        private string som;
        public Animal(string _nome, string _raca, string _som)
        {
            nome = _nome;
            raca = _raca;
            som = _som;
        }
        public string Nome
        {
            get{return nome;}
            set{nome = value;}
        }
        public string Raca
        {
            get{return raca;}
            set{raca = value;}
        }
        public string Som
        {
            get{return som;}
            set{som = value;}
        }
        public void Comer()
        {
            Console.WriteLine($"O animal da raça {raca} está comendo!");
        }
        public void EmitirSom()
        {
            Console.WriteLine($"O {raca} {som}");
        }
        public abstract void FazerAcao();
    }
    class Gato : Animal
    {
        public Gato(string nome, string raca, string som):base(nome, raca, som){}
        public override void FazerAcao()
        {
            Console.WriteLine($"O {nome} está brincando com novelo de lã!");
        }
    }
    class Cachorro : Animal
    {  
        public Cachorro(string nome, string raca, string som):base(nome, raca, som){}
        public override void FazerAcao()
        {
            Console.WriteLine($"O {nome} está correndo atrás do graveto!");
        }
    }
    class Vaca : Animal
    {
        public Vaca(string nome, string raca, string som):base(nome, raca, som){}
        public override void FazerAcao()
        {
            Console.WriteLine($"A {nome} está sendo ordenhada!");
        }
    }
    class Leao : Animal
    {
        public Leao(string nome, string raca, string som):base(nome, raca, som){}
        public override void FazerAcao()
        {
            Console.WriteLine($"O {nome} está caçando!");
        }
    }
    class Galinha : Animal
    {
        public Galinha(string nome, string raca, string som):base(nome, raca, som){}
        public override void FazerAcao()
        {
            Console.WriteLine($"A {nome} está botando um ovo!");
        }
    }
    class Ganco : Animal
    {
        public Ganco(string nome, string raca, string som):base(nome, raca, som){}
        public override void FazerAcao()
        {
            Console.WriteLine($"O {nome} está nadando na lagoa!");
        }
    }
    class Sapo : Animal
    {
        public Sapo(string nome, string raca, string som):base(nome, raca, som){}
        public override void FazerAcao()
        {
            Console.WriteLine($"O {nome} está pulando nas vitórias regias!");
        }
    }
    class Andorinha : Animal
    {
        public Andorinha(string nome, string raca, string som):base(nome, raca, som){}
        public override void FazerAcao()
        {
            Console.WriteLine($"{nome} está voando!");
        }
    }
    static void SomAnimal(List<Animal> lista, string animalEntrada)
    {
        bool temNaLista = false;

        foreach(var animal in lista)
        {
            if(animal.Raca.ToLower() == animalEntrada)
            {
                temNaLista = true;
                animal.EmitirSom();
                break;
            }
        }
        if(!temNaLista)
        {
            Console.WriteLine($"Animal {animalEntrada} não cadastrado!");
        }
    }
    static void AcaoAnimal(List<Animal> lista, string animalEntrada)
    {
        bool temNaLista = false;

        foreach(var animal in lista)
        {
            if(animal.Raca.ToLower() == animalEntrada)
            {
                temNaLista = true;
                animal.FazerAcao();
                break;
            }
        }
        if(!temNaLista)
        {
            Console.WriteLine($"Animal {animalEntrada} não cadastrado!");
        }   
    }
}
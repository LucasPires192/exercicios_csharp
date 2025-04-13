using System;

class Program
{
    static void Main()
    {
        Pessoa pessoa = new Pessoa();
        
        Console.WriteLine("Olá! Qual é o seu nome?");
        
        pessoa.Nome = Console.ReadLine();

        Console.WriteLine($"Bem vindo {pessoa.Nome}! Quantos anos você tem?");
        
        int idade;

        while(true)
        {
            string entrada = Console.ReadLine();

            if(!int.TryParse(entrada, out idade))
            {
                Console.WriteLine("Idade Invalida! Tente digitar um número com a sua idade!");
            }else
            {   
                pessoa.Idade = idade;
                break;
            }
        }

        pessoa.Apresentar();
    }
    
    class Pessoa{
        public string Nome;
        public int Idade;

        public void Apresentar(){
            Console.WriteLine($"Prazer em te conhecer {Nome}! Então você tem {Idade} anos. Que legal");
        }
    }
}
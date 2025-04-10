using System;

class Program{
    static void Main() {
        int numero1;
        int numero2;
        int numero3;
        
        while(true){
            Console.WriteLine("Digite o 1° numero: ");
            string entrada = Console.ReadLine();
            if(!int.TryParse(entrada, out var n1)){
                Console.WriteLine("Valor Invalido! Digite Novamente\n");        
            }else{
                numero1 = n1;
                break;
            }
        }while(true){
            Console.WriteLine("Digite o 2° numero: ");
            string entrada = Console.ReadLine();
            if(!int.TryParse(entrada, out var n2)){
                Console.WriteLine("Valor Invalido! Digite Novamente\n");        
            }else{
                numero2 = n2;
                break;
            }
        }
        while(true){
            Console.WriteLine("Digite o 3° numero: ");
            string entrada = Console.ReadLine();
            if(!int.TryParse(entrada, out var n3)){
                Console.WriteLine("Valor Invalido! Digite Novamente\n");      
            }else{
                numero3 = n3;
                break;
            }
        }
        
        Console.WriteLine($"{numero1} + {numero2} + {numero3} = {Somar(numero1, numero2, numero3)}");
        
        Console.WriteLine("Digite seu nome!");
        string nome = Console.ReadLine();
        
        Console.WriteLine(Saudacao(nome));
        
        int numero;
        while(true){
            Console.WriteLine("Digite um numero");
            string entrada = Console.ReadLine();
            if(!int.TryParse(entrada, out var n)){
                Console.WriteLine("Valor Invalido! Digite Novamente\n");        
            }else{
                numero = n;
                break;
            }
        }
        
        Console.WriteLine(EhMultiploDeCinco(numero));
    }
    
    static int Somar(int n1, int n2, int n3){
        return n1 + n2 + n3;
    }
    
    static string Saudacao(string nome){
        return $"Olá {nome}! Seja bem vindo!";
    }
    
    static string EhMultiploDeCinco(int num){
        int resultado = num % 5;
        if(resultado == 0){
            return $"O número {num} é multiplo de 5";
        }else{
            return $"O número {num} não é multiplo de 5";
        }
    }
}
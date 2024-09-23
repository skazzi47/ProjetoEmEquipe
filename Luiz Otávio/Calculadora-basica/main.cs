using System;

class Program {
  public static void Main (string[] args) {
    repetir:
    Console.Write("Insira os valores que deseja utilizar : ");
    if(!float.TryParse(Console.ReadLine(), out float um)){
      Console.WriteLine("Erro! Número inválido.");
      goto repetir;
    }
    if(!float.TryParse(Console.ReadLine(), out float dois)){
      Console.WriteLine("Erro! Número inválido.");
      goto repetir;
    }
    repetir2:
    Console.WriteLine("(1) Soma   (2) Subtração\n(3) Multiplicação   (4) Divisão\n");
    Console.Write("Insira o tipo de operação que deseja realizar : ");
    if(!char.TryParse(Console.ReadLine(), out char op)){
      Console.WriteLine("Erro! Número inválido.");
      goto repetir2;
    }
    switch(op){
      case '1':
        Console.WriteLine($"O resultado é : {um + dois}");
      break;

      case '2':
        Console.WriteLine($"O resultado é : {um - dois}");
      break;

      case '3':
        Console.WriteLine($"O resultado é : {um * dois}");
      break;

      case '4':
        Console.WriteLine($"O resultado é : {um / dois}");
      break;
    }
  }
}
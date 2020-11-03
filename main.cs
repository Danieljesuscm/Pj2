using System;
using System.Collections.Generic;


class MainClass {
  public static void Main (){
    Random rdn = new Random();
    cliente cleber = new cliente();
    cleber.Setnome  ("cleber do rodó pereira");
    cleber.Setendereco ("Rua Jurucu n° 24");
    cleber.telefone= 155782529;
    cleber.email= "clebin-o-mais-brabo@gmail";

    loja bh = new loja();

    carinho car = new carinho("coca",3,3,233);
    List<carinho> Lista_carinho = new List<carinho>();

    car.Setcltdono ("cleber do rodó pereira");

    Console.WriteLine("       Nome       |     Preço");
    for (int i = 0; i < bh.Getdescricao().Count;i++){
      Console.WriteLine($@"{bh.Getdescricao()[i]} - {bh.Getpreco()[i]} - {bh.getCodigo()[i]}");
    }

    int codigo,pedQuant;
    string decis = "S";
    while (decis == "S") {
      
      Console.Write("Digite o código do Produto que deseja comprar ~ ");
      
      codigo = int.Parse(Console.ReadLine());

      Console.Write("Digite a quantidade do produto ~ ");
      pedQuant = int.Parse(Console.ReadLine());

      for(int i = 0; i < bh.Getdescricao().Count;i++){
        if(bh.getCodigo()[i] == codigo & bh.Getqtditens()[i] < pedQuant){
          

          car  = new carinho(bh.Getdescricao()[i],pedQuant,bh.getCodigo()[i],bh.Getpreco()[i]);

          Lista_carinho.Add(car);
        
        }
      }
      Console.Write("Insira S para continuar ou N para Sair ~");
      decis = Console.ReadLine();

    }

    double total = 0;

    for (int i = 0; i < Lista_carinho.Count;i++){
      Console.WriteLine($"Produto ~ {Lista_carinho[i].Getitens()[i]}\n código ~ {Lista_carinho[i].Getcodigo()} \n quantidade ~ {Lista_carinho[i].Getqtditens()} \n Valor ~ {Lista_carinho[i].Getpreco()} \n-------------------------------------------");

      total = total + (Lista_carinho[i].Getpreco()*Lista_carinho[i].Getqtditens());
    }

    decis = "S";
    string retirar;
    while (decis == "S") {
      Console.Write("Deseja retirar algum item do Carrinho ? S/N ~");
      retirar = Console.ReadLine();

      if (retirar == "S"){
          Console.Write("Digite o código do Produto que deseja retirar ~ ");
      
          codigo = int.Parse(Console.ReadLine());

         for (int i = 0; i < Lista_carinho.Count;i++){

           if (codigo == Lista_carinho[i].Getcodigo() ){
             Lista_carinho.RemoveAt(x);
           }
     
        }
      }
      else{
        decis = "N";
      }
    }
    Console.WriteLine("Seu Carrinho de Compras");
    
    for (int i = 0; i < Lista_carinho.Count;i++){
      Console.WriteLine($"Produto ~ {Lista_carinho[i].Getitens()[i]}\n código ~ {Lista_carinho[i].Getcodigo()} \n quantidade ~ {Lista_carinho[i].Getqtditens()} \n Valor ~ {Lista_carinho[i].Getpreco()} \n-------------------------------------------");

    }

    Console.WriteLine($"Total da Compra >> {total}");
    
    Console.WriteLine($"Foi Gerado Um código de Boleto Bancario para o Pagamento.\nO código para Pagamento >> {bdn}");
  }
}

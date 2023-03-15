// See https://aka.ms/new-console-template for more information
using ConsoleApp_Tarde;
using ConsoleApp_Tarde.Heranca2;
using Microsoft.VisualBasic;

Produto p1 = new Produto(1,"Mouse xing ling", 10.90M);
Produto p2 = new Produto(2,"Teclado multilaser", 20.90M);

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

p1.setValor(29.90M);
p1.setDescricao("Mouse Razer");

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

Console.WriteLine(" ");
Console.WriteLine(" ");

Endereco e1 = new Endereco(1, "15906304", "Mario Miziara", 91, "Sobral", "Taquaritinga"
    );

Cliente c1 = new Cliente(1, "Gustavo", "991340447",e1);
Cliente c2 = new Cliente(2, "Victoria", "991340447",e1);
Cliente c3 = new Cliente(3, "Rafael", "991340447", e1);
Cliente c4 = new Cliente(4, "Lucas", "9913409876" ,e1  );
Cliente c5 = new Cliente(5, "Eduardo", "991340447", e1);


Console.WriteLine(c1.getEndereco().EnderecoCompleto()  );
c1.getEndereco().setRua("Prudente de Morais");
Console.WriteLine(c1.getEndereco().EnderecoCompleto() );
c1.getEndereco().AtualizarEndereco("Julio de Moraes", 585, "POrtal Itamaraca");
Console.WriteLine(c1.getEndereco().EnderecoCompleto());

Console.WriteLine(" ");
Console.WriteLine(" ");

Carro car = new Carro();
car.cor = "vermelho";
car.quantidadedeRodas = 4;
car.quantidadedeAssentos = 5;
car.TemMotor = true;

Bike bicicleta = new Bike();
bicicleta.cor = "Azul";
bicicleta.quantidadedeRodas = 2;
bicicleta.quantidadedeAssentos = 1;
bicicleta.TemMotor = false;

Aviao aviao = new Aviao();
aviao.quantidadedeRodas = 12;
aviao.quantidadedeAssentos = 500;
aviao.cor = "Branco";
aviao.TemMotor = true;

List<Veiculo> veiculoLista = new List <Veiculo>();
veiculoLista.Add(car);
veiculoLista.Add(aviao);
veiculoLista.Add(bicicleta);

foreach (var item in veiculoLista)
{
    Console.WriteLine(item.ExibirDados());
}

Console.WriteLine("Qtd itens da Lista" +veiculoLista.Count);
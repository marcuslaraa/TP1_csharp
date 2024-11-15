using Polimorfismo;
int op = 0;
CestaDeCompras cesta = new CestaDeCompras();
Produto p1 = new Notebook("Samsumg", "preto");

do
{
    Console.WriteLine("Deseja qual opçao:");
    Console.WriteLine("1 - Incluir um dos produtos na cesta");
    Console.WriteLine("2 - Reajustar o preço de todos os produtos");
    Console.WriteLine("3 - Exibir a cesta de produtos");
    Console.WriteLine("4 - Exibir total da compra");

    op = int.Parse(Console.ReadLine());
    
    if(op == 0) Console.WriteLine("Até mais");

    switch(op)
    {
        case 1:
            cesta.adicionarProduto(p1);
            break;
            
    }


} while (op != 0);
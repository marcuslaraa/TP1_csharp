using TP1_csharp;

ContaCorrente cc = new ContaCorrente("1234", "2525", "Marcus");
ContaPoupanca cp = new ContaPoupanca("1111", "2222", "teste");

cc.creditar(100);
cp.creditar(100);

Console.WriteLine($"Novo saldo cp: {cp.Saldo}");

Console.WriteLine($"Novo saldo cc: {cc.Saldo}");

cc.debitar(10);
cp.debitar(5);

Console.WriteLine($"Novo saldo cp: {cp.Saldo}");

Console.WriteLine($"Novo saldo cc: {cc.Saldo}");

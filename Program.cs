decimal GastoMensais, ValorAInvestir;
double dividendYield;

Console.WriteLine("--- Vivendo de dividendos ---\n");

Console.Write("Gastos mensais (em R$)...: ");
GastoMensais = Convert.ToDecimal(Console.ReadLine());

Console.Write("Rendimentos mensais (%)...:");
dividendYield = Convert.ToDouble(Console.ReadLine());

ValorAInvestir = GastoMensais / Convert.ToDecimal(dividendYield / 100);

Console.WriteLine($"\nPara receber {GastoMensais:C} por mês em rendimentos de {dividendYield:N1} % voce precisa ter investido { ValorAInvestir :C}.");

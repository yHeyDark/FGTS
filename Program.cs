double sala, fgts;

Console.Write("Digite o Salario: ");
sala = Convert.ToDouble(Console.ReadLine());
fgts = sala*0.08;
Console.WriteLine($"Salario de ...: {sala:N2}");
Console.Write($"O seu fundo de garantia e de  R$ {fgts:N2}");
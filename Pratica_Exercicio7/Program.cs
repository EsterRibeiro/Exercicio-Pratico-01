using Pratica_Exercicio7.Entities;
using Pratica_Exercicio7.Repositories;

var funcionario = new Funcionario();
funcionario.Id = Guid.NewGuid();

Console.WriteLine("Informe os dados do funcionário:\n");

Console.Write("Nome: ");
funcionario.Nome = Console.ReadLine();

Console.Write("CPF: ");
funcionario.Cpf = Console.ReadLine();

Console.Write("Matrícula: ");
funcionario.Matricula = Console.ReadLine();

Console.Write("Data de admissão: ");
funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

Console.Write("Cargo: ");
funcionario.Cargo = Console.ReadLine();

Console.Write("Salário: ");
funcionario.Salario = decimal.Parse(Console.ReadLine());

var funcionarioRepository = new FuncionarioRepository();

funcionarioRepository.ExportarDados(funcionario);

Console.WriteLine("Dados do funcionário\n");
Console.WriteLine($"\nCpf: {funcionario.Cpf}");
Console.WriteLine($"\nMatrícula: {funcionario.Matricula}");
Console.WriteLine($"\nData de admissão: {funcionario.DataAdmissao}");
Console.WriteLine($"\nCargo: {funcionario.Cargo}");
Console.WriteLine($"\nSalario: {funcionario.Salario}");

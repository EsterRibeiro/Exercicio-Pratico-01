using Pratica_Exercicio7.Entities;

namespace Pratica_Exercicio7.Repositories;
public class FuncionarioRepository
{
    public void ExportarDados(Funcionario funcionario)
    {
        var streamWriter = new StreamWriter(@"c:\temp\funcionario.txt", true);

        streamWriter.WriteLine($"Nome: { funcionario.Nome }");
        streamWriter.WriteLine($"Cpf: {funcionario.Cpf}");
        streamWriter.WriteLine($"Matrícula: {funcionario.Matricula}");
        streamWriter.WriteLine($"Data de admissão: {funcionario.DataAdmissao}");
        streamWriter.WriteLine($"Cargo: {funcionario.Cargo}");
        streamWriter.WriteLine($"Salario: {funcionario.Salario}");

        streamWriter.Close();
    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        List<Medico> medicos = new List<Medico>();
        List<Paciente> pacientes = new List<Paciente>();
        
        int opcao;
        
        do
        {
            Console.WriteLine("----------- Menu -----------");
            Console.WriteLine("1. Inserir Médico");
            Console.WriteLine("2. Inserir Paciente");
            Console.WriteLine("3. Imprimir Médicos com idade entre");
            Console.WriteLine("4. Imprimir Pacientes com idade entre");
            Console.WriteLine("5. Imprimir Pacientes com sexo informado");
            Console.WriteLine("6. Imprimir Pacientes em ordem alfabética");
            Console.WriteLine("7. Imprimir Pacientes com sintomas informados");
            Console.WriteLine("8. Imprimir Aniversariantes do Mês");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");

            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        InserirMedico();
                        break;
                    case 2:
                        InserirPaciente();
                        break;
                    case 3:
                        Relatorios.ImprimirMedicosComIdadeEntre();
                        break;
                    case 4:
                        Relatorios.ImprimirPacientesComIdadeEntre();
                        break;
                    case 5:
                        Relatorios.ImprimirPacientesComSexoInformado();
                        break;
                    case 6:
                        Relatorios.ImprimirPacientesEmOrdemAlfabetica();
                        break;
                    case 7:
                        Relatorios.ImprimirPacientesComSintomasInformado();
                        break;
                    case 8:
                        Relatorios.ImprimirAniversariantesDoMes();
                        break;
                    case 0:
                        Console.WriteLine("Programa encerrado.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Tente novamente.");
            }

            Console.WriteLine();
        } while (opcao != 0);
    }

    static void InserirMedico()
    {
        Console.Write("Nome do médico: ");
        string nome = Console.ReadLine();
        Console.Write("Data de Nascimento (YYYY-MM-DD): ");
        DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
        Console.Write("CPF: ");
        string cpf = Console.ReadLine();
        Console.Write("CRM: ");
        string crm = Console.ReadLine();

        medicos.Add(new Medico(nome, dataNascimento, cpf, crm));
        Console.WriteLine("Médico inserido com sucesso.");
    }

    static void InserirPaciente()
    {
        // Obtenha os dados do paciente do usuário
        Console.Write("Nome do paciente: ");
        string nome = Console.ReadLine();
        Console.Write("Data de Nascimento (YYYY-MM-DD): ");
        DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
        Console.Write("CPF: ");
        string cpf = Console.ReadLine();
        Console.Write("Sexo (ou pressione Enter para 'Não informado'): ");
        string sexo = Console.ReadLine();
        Console.Write("Sintomas (ou pressione Enter para 'Não informado'): ");
        string sintomas = Console.ReadLine();

        // Crie um novo paciente e adicione à lista
        pacientes.Add(new Paciente(nome, dataNascimento, cpf, sexo, sintomas));
        Console.WriteLine("Paciente inserido com sucesso.");
    }

    
}

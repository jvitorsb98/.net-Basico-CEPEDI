using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Medico> medicos = new List<Medico>();
        for (int i = 1; i <= 9; i++)
        {
            medicos.Add(new Medico($"Dr. Médico{i}", new DateTime(1980 + i, 1, 1), $"1234567890{i}", $"{i}"));
        }

        List<Paciente> pacientes = new List<Paciente>();
        for (int i = 9; i >=0 ; i--)
        {
            pacientes.Add(new Paciente($"Paciente{i}", new DateTime(1995 - i, 5, 15), $"9876543210{i}", i % 2 == 0 ? "masculino" : "feminino", $"Sintomas{i}"));
        }
        pacientes.Add(new Paciente($"Paciente Sem informar sexo e sintoma", new DateTime(1992, 5, 15), $"98765432119"));
        pacientes.Add(new Paciente($"Paciente Sem informar sexo e sintoma 2 ", new DateTime(1991, 5, 18), $"98765442119"));


        // Testar funcionalidades
        Relatorios.ImprimeMedicosComIdadeEntre(medicos, 35, 45);

        Relatorios.ImprimePacientesComIdadeEntre(pacientes, 20, 30);

        Relatorios.ImprimePacientesComSexoInformado(pacientes, 20, 30);

        Relatorios.ImprimePacientesEmOrdemAfabetica(pacientes);

        Relatorios.ImprimePacientesComSintomaInformado(pacientes);

        Relatorios.ImprimeAniversariantesDoMes(medicos, pacientes, 1);
        Relatorios.ImprimeAniversariantesDoMes(medicos, pacientes, 2);

    }
}

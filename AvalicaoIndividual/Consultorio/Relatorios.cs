using System.Linq;
using System.Collections.Generic;
public static class Relatorios
{
    public static List<Medico> MedicosComIdadeEntre(List<Medico> medicos, int idadeMin, int idadeMax)
    {
        return medicos.Where(m =>
        {
            DateTime dataAtual = DateTime.Today;
            DateTime aniversarioEsteAno = m.DataNascimento.AddYears(dataAtual.Year - m.DataNascimento.Year);

            int idade = dataAtual.Year - m.DataNascimento.Year;

            if (DateTime.Compare(dataAtual, aniversarioEsteAno) < 0)
            {
                idade--;
            }

            return idade >= idadeMin && idade <= idadeMax;
        }).ToList();
    }

    public static List<Paciente> PacientesComIdadeEntre(List<Paciente> pacientes, int idadeMin, int idadeMax)
    {
        return pacientes.Where(p =>
        {
            DateTime dataAtual = DateTime.Today;
            DateTime aniversarioEsteAno = p.DataNascimento.AddYears(dataAtual.Year - p.DataNascimento.Year);

            int idade = dataAtual.Year - p.DataNascimento.Year;

            if (DateTime.Compare(dataAtual, aniversarioEsteAno) < 0)
            {
                idade--;
            }

            return idade >= idadeMin && idade <= idadeMax;
        }).ToList();
    }

    public static List<Paciente> PacientesComSexoInformado(List<Paciente> pacientes){
        return pacientes.Where(p => p.Sexo != "Não informado").ToList();
    }

    public static List<Paciente> PacientesEmOrdemAlfabetica(List<Paciente> pacientes){
        return pacientes.OrderBy(p => p.Nome).ToList();
    }

    public static List<Paciente> PacientesComSintomasInformado(List<Paciente> pacientes){
        return pacientes.Where(p => p.Sintomas != "Não informado").ToList();
    }






}

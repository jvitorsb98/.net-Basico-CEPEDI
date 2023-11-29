using System.Linq;

public static class Relatorios
{
    public static List<Medico> MedicosComIdadeEntre(List<Medico> medicos, int idadeMin, int idadeMax)
    {
        DateTime dataAtual = DateTime.Now;
        return medicos.Where(m => (dataAtual.Year - m.DataNascimento.Year) >= idadeMin &&
                                   (dataAtual.Year - m.DataNascimento.Year) <= idadeMax).ToList();
    }

}

public class Medico : Pessoa
{
    public string CRM { get; set; }

    public Medico(string nome, DateTime dataNascimento, string cpf, string crm) 
        : base(nome, dataNascimento, cpf)
    {
        CRM = crm;
    }

    public override string ToString()
    {
        return $"Médico: {Nome}, CRM: {CRM}";
    }
}
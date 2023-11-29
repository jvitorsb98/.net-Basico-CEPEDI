public abstract class Pessoa
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    private string cpf;

    public string CPF
    {
        get { return cpf; }
        set
        {
            if (ValidarCPF(value)){
                cpf = value;
            }
            else{
                throw new ArgumentException("CPF inválido");
            }
        }
    }

    public Pessoa(string nome, DateTime dataNascimento, string cpf)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
        if(ValidarCPF(cpf)){
            CPF = cpf;
        }
    }

    public abstract string Relatorio();

    private bool ValidarCPF(string cpf)
    {
        if (cpf.Length != 11)
        {
            return false;
        }

        foreach (char c in cpf)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }

        return true;
    }
}
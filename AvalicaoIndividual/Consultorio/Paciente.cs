class Paciente : Pessoa
{
    public string Sexo { get; set; }
    public string Sintomas { get; set; }

    public Paciente(string nome, DateTime dataNascimento, string cpf, string sexo, string sintomas)
        : base(nome, dataNascimento, cpf)
    {
        Sexo = sexo;
        Sintomas = sintomas;
    }

    private bool isSexo(string sexo){
        if(sexo == "m" || sexo=="f"){
            Sexo = sexo;
        }else{
            throw new ArgumentException("Inválida inserção de sexo (Insira m(masculino) ou f(feminino)");
        }
    }

    public override string Relatorio()
    {
        return $"Paciente: {Nome}, Sexo: {Sexo}, Sintomas: {Sintomas}";
    }
}

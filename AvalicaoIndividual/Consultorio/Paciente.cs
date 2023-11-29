public class Paciente : Pessoa
{
    private string Sexo { get; set; }
    private string Sintomas { get; set; }

public Paciente(string nome, DateTime dataNascimento, string cpf, string sexo, string sintomas)
    : base(nome, dataNascimento, cpf)
    {
    if (!IsSexo(sexo)){
        throw new ArgumentException("Inválida inserção de sexo (Insira (masculino) ou (feminino)");
    }

    Sexo = sexo;
    Sintomas = sintomas;
}


    private bool IsSexo(string sexo){
        if(sexo == "masculino" || sexo=="feminino"){
            Sexo = sexo;
            return true;
        }else{
            throw new ArgumentException("Inválida inserção de sexo (Insira (masculino) ou (feminino)");
        }
        return false;
    }

}

namespace Atividade
{
    // o " : Cliente" indica que "Pessoa_Fisica" herda atributos de "Clientes"
    class Pessoa_Fisica : Clientes
    {
        public string cpf {get; set;}
        public string rg {get; set;}
    }
}
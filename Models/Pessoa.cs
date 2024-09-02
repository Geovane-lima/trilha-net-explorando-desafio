namespace DesafioProjetoHospedagem.Models
{
    public class Pessoa
    {
        // Construtor padrão
        public Pessoa() { }

        // Construtor com nome
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        // Construtor com nome e sobrenome
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        // Propriedades
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        // Propriedade somente leitura para o nome completo
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
    }
}
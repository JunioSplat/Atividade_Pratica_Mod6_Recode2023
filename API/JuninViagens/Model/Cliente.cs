using System.ComponentModel.DataAnnotations.Schema;

namespace JuninViagens.Model
{
    [Table("clientes")]
    public class Cliente
    {

        [Column("id")]
        public int Id { get; set; }

        public string enderecoCli { get; set; } = string.Empty;

        public string nomeCli { get; set; } = string.Empty;

        public string EmailCli { get; set; } = string.Empty;

        public string cepCli { get; set; } = string.Empty;
    }
}
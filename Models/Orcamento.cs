using System;

namespace PI_ATV04_Bruno_Mello.Models
{
    public class Orcamento
    {
        public int idOrcamento {get; set;}
        public string qtdPessoas {get; set;}
        public bool sub {get; set;}
        public bool iluminacao {get; set;}
        public string mensagem {get; set;}
        public DateTime dataEvento {get; set;}
    }
}
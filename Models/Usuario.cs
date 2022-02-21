using System;

namespace PI_ATV04_Bruno_Mello.Models
{
    public class Usuario
    {
        public static int ADMIN = 0;
        public static int PADRAO = 1;


        public int Id {get; set;}
        public string Nome {get; set;}
        public string Telefone {get; set;}
        public string Email {get; set;}
        public string Login {get; set;}
        public string Senha {get; set;}
        public int Tipo {get; set;}
        
    }
}
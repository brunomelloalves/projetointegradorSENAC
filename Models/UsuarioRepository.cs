using System;
using System.Collections.Generic;
using MySqlConnector;

namespace PI_ATV04_Bruno_Mello.Models
{
       public class UsuarioRepository
    {
        private const string DadosConexao = "Database=bsound; Data Source=localhost; User Id=root;";

        public void TestarConexao(){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open(); //abre a conexão com o banco de dados 
            Console.WriteLine("Banco de dados funcionando!");
            Conexao.Close();//fecha a coenxão com banco de dados 
        }

        public Usuario ValidarLogin(Usuario user){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            String Query = "SELECT * FROM Usuario WHERE Login=@Login and Senha=@Senha"; 
            MySqlCommand Comando =  new MySqlCommand(Query,Conexao);
            
            Comando.Parameters.AddWithValue("Login", user.Login);
            Comando.Parameters.AddWithValue("Senha", user.Senha);
            MySqlDataReader Reader = Comando.ExecuteReader();
            
            Usuario UsuarioEncontrado = null;//aqui esta o pulo do gato

            if(Reader.Read()){
                UsuarioEncontrado = new Usuario();
                UsuarioEncontrado.Id = Reader.GetInt32("Id");

                if(!Reader.IsDBNull (Reader.GetOrdinal("Nome")))
                UsuarioEncontrado.Nome = Reader.GetString("Nome");
               
                if(!Reader.IsDBNull (Reader.GetOrdinal("Telefone")))
                UsuarioEncontrado.Nome = Reader.GetString("Telefone");

                if(!Reader.IsDBNull (Reader.GetOrdinal("Login")))
                UsuarioEncontrado.Nome = Reader.GetString("Login");

                if(!Reader.IsDBNull (Reader.GetOrdinal("Senha")))
                UsuarioEncontrado.Nome = Reader.GetString("Senha");

            }

            Conexao.Close();//fecha a coenxão com banco de dados 
            return UsuarioEncontrado;
        }
        public Usuario BuscarPorId(int Id){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            String Query = "SELECT * FROM Usuario WHERE Id=@Id"; 
            MySqlCommand Comando =  new MySqlCommand(Query,Conexao);
            
            Comando.Parameters.AddWithValue("@Id", Id);
            MySqlDataReader Reader = Comando.ExecuteReader();
            
            Usuario UsuarioEncontrado = new Usuario();

            if(Reader.Read()){
                UsuarioEncontrado.Id = Reader.GetInt32("Id");

                if(!Reader.IsDBNull (Reader.GetOrdinal("Nome")))
                UsuarioEncontrado.Nome = Reader.GetString("Nome");

                
                if(!Reader.IsDBNull (Reader.GetOrdinal("Telefone")))
                UsuarioEncontrado.Telefone = Reader.GetString("Telefone");

                
                if(!Reader.IsDBNull (Reader.GetOrdinal("Email")))
                UsuarioEncontrado.Email = Reader.GetString("Email");

                if(!Reader.IsDBNull (Reader.GetOrdinal("Login")))
                UsuarioEncontrado.Login = Reader.GetString("Login");

                if(!Reader.IsDBNull (Reader.GetOrdinal("Senha")))
                UsuarioEncontrado.Senha = Reader.GetString("Senha");

                if(!Reader.IsDBNull (Reader.GetInt32("Tipo")))
                UsuarioEncontrado.Senha = Reader.GetString("Tipo");

                
            }

            Conexao.Close();
            return UsuarioEncontrado;
        }

        public List<Usuario> Listar(){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();  

            String Query = "SELECT * FROM Usuario"; 
            
            MySqlCommand Comando =  new MySqlCommand(Query,Conexao);
            
            
            MySqlDataReader Reader = Comando.ExecuteReader();

            List<Usuario> Lista = new List<Usuario>(); //criando uma lista de usuario da classe Usuario vazia

            
            while (Reader.Read()){
                Usuario userEncontrado = new Usuario();

                userEncontrado.Id = Reader.GetInt32("Id");

                if(!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    userEncontrado.Nome = Reader.GetString("Nome");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Telefone")))
                    userEncontrado.Telefone =Reader.GetString("Telefone");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Email")))
                    userEncontrado.Email = Reader.GetString("Email");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                    userEncontrado.Login = Reader.GetString("Login");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                    userEncontrado.Senha = Reader.GetString("Senha");                
                if(!Reader.IsDBNull(Reader.GetInt32("Tipo")))
                    userEncontrado.Tipo = Reader.GetInt32("Tipo");                
                Lista.Add(userEncontrado);
            }
            Conexao.Close();   
            return Lista; //retornando a lista de Usuario
        }

        public void Cadastrar(Usuario user){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();  
            String Query = "INSERT INTO Usuario (Id, Nome, Telefone, Email, Login, Senha, Tipo) Values (@Id, @Nome, @Telefone, @Email, @Login, @Senha, @Tipo)";
            MySqlCommand Comando =  new MySqlCommand(Query,Conexao);  
            Comando.Parameters.AddWithValue("@Id",user.Id);            
            Comando.Parameters.AddWithValue("@Nome",user.Nome); 
            Comando.Parameters.AddWithValue("@Telefone",user.Telefone); 
            Comando.Parameters.AddWithValue("@Email",user.Email);
            Comando.Parameters.AddWithValue("@Login",user.Login); 
            Comando.Parameters.AddWithValue("@Senha",user.Senha);  
            Comando.Parameters.AddWithValue("@Tipo",user.Tipo);  
            
            Comando.ExecuteNonQuery();               
            Conexao.Close();   
        }

        public void Editar(Usuario user){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();  
            String Query = "UPDATE Usuario SET Nome=@Nome, Telefone=@Telefone, Email=@Email, Tipo=@Tipo,  WHERE Id=@Id";
            MySqlCommand Comando =  new MySqlCommand(Query,Conexao);             
            Comando.Parameters.AddWithValue("@Id",user.Id); 
            Comando.Parameters.AddWithValue("@Nome",user.Nome); 
            Comando.Parameters.AddWithValue("@Telefone",user.Telefone); 
            Comando.Parameters.AddWithValue("@Email",user.Email); 
            Comando.Parameters.AddWithValue("@Login",user.Login); 
            Comando.Parameters.AddWithValue("@Senha",user.Senha); 
            Comando.Parameters.AddWithValue("@Tipo",user.Tipo); 
            Comando.ExecuteNonQuery();               
            Conexao.Close();
        }

        //query SQL para exclusão (delete from Usuario where condição) 
        public void Excluir(Usuario user){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();        
            String Query = "DELETE FROM Usuario WHERE Id=@Id";
            MySqlCommand Comando =  new MySqlCommand(Query,Conexao); //preparando o SQL para o objeto de conexão            
            Comando.Parameters.AddWithValue("@Id",user.Id); // tratamento para sql injection 
            Comando.ExecuteNonQuery();   //Executa a query no banco de dados                           
            Conexao.Close();
        }
    }
}
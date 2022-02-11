using System;
using System.Collections.Generic;
using MySqlConnector;

namespace PI_ATV04_Bruno_Mello.Models
{
    public class OrcamentoRepository
    {
       
       
        private const string DadosConexao = "Database=bsound; Data Source=localhost; User Id=root;";

    
        public Orcamento BuscarPorId(int idOrcamento){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            String Query = "SELECT * FROM Orcamento WHERE idOrcamento=@idOrcamento"; 
            MySqlCommand Comando =  new MySqlCommand(Query,Conexao);
            
            Comando.Parameters.AddWithValue("@idOrcamento", idOrcamento);
            MySqlDataReader Reader = Comando.ExecuteReader();
            
            Orcamento OrcamentoEncontrado = new Orcamento();

            if(Reader.Read()){
                OrcamentoEncontrado.idOrcamento = Reader.GetInt32("idOrcamento");
                OrcamentoEncontrado.idOrcamento = Reader.GetInt32("usuarioId");

                if(!Reader.IsDBNull (Reader.GetOrdinal("qtdPessoas")))
                OrcamentoEncontrado.qtdPessoas = Reader.GetString("qtdPessoas");

                if(!Reader.IsDBNull (Reader.GetOrdinal("sub")))
                OrcamentoEncontrado.sub = Reader.GetBoolean("sub");

                if(!Reader.IsDBNull (Reader.GetOrdinal("iluminacao")))
                OrcamentoEncontrado.iluminacao = Reader.GetBoolean("iluminacao");

                if(!Reader.IsDBNull (Reader.GetOrdinal("mensagem")))
                OrcamentoEncontrado.mensagem = Reader.GetString("mensagem");
                
                OrcamentoEncontrado.dataEvento = Reader.GetDateTime("dataEvento");
            }

            

            Conexao.Close();
            return OrcamentoEncontrado;
        }

        public List<Orcamento> Listar(){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();  

            String Query = "SELECT * FROM Orcamento"; 
            
            MySqlCommand Comando =  new MySqlCommand(Query,Conexao);
            
            MySqlDataReader Reader = Comando.ExecuteReader();

            List<Orcamento> Lista = new List<Orcamento>(); 

            while (Reader.Read()){
                Orcamento orcEncontrado = new Orcamento();

                orcEncontrado.idOrcamento = Reader.GetInt32("idOrcamento");

                if(!Reader.IsDBNull(Reader.GetOrdinal("qtdPessoas")))
                    orcEncontrado.qtdPessoas = Reader.GetString("qtdPessoas");

                if(!Reader.IsDBNull(Reader.GetOrdinal("sub")))
                    orcEncontrado.sub = Reader.GetBoolean("sub");

                if(!Reader.IsDBNull(Reader.GetOrdinal("iluminacao")))
                    orcEncontrado.iluminacao = Reader.GetBoolean("iluminacao"); 

                if(!Reader.IsDBNull(Reader.GetOrdinal("mensagem")))
                    orcEncontrado.mensagem = Reader.GetString("mensagem");

                orcEncontrado.dataEvento = Reader.GetDateTime("dataEvento");
                
                orcEncontrado.Usuario.Nome = Reader.GetString("Nome");
                
                                
                Lista.Add(orcEncontrado);
            }
            Conexao.Close();   
            return Lista; 
        }

        public void Cadastrar(Orcamento orc){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();  
            String Query = "INSERT INTO Orcamento (qtdPessoas, sub, iluminacao, mensagem, dataEvento) Values (@qtdPessoas, @sub, @iluminacao, @mensagem, @dataEvento)";
            MySqlCommand Comando =  new MySqlCommand(Query,Conexao);             
            Comando.Parameters.AddWithValue("@qtdPessoas",orc.qtdPessoas); 
            Comando.Parameters.AddWithValue("@sub",orc.sub);
            Comando.Parameters.AddWithValue("@iluminacao",orc.iluminacao);
            Comando.Parameters.AddWithValue("@mensagem",orc.mensagem);
            Comando.Parameters.AddWithValue("@dataEvento",orc.dataEvento);
            Comando.Parameters.AddWithValue("@usuarioId",orc.Usuario.Nome);//verificar
            
            Comando.ExecuteNonQuery();               
            Conexao.Close();   
        }

        public void Editar(Orcamento orc){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();  
            String Query = "UPDATE Orcamento SET qtdPessoas=@qtdPessoas, sub=@sub, iluminacao=@iluminacao, mensagem=@mensagem, dataEvento=@dataEvento WHERE idOrcamento=@idOrcamento";
            MySqlCommand Comando =  new MySqlCommand(Query,Conexao);             
            Comando.Parameters.AddWithValue("@idOrcamento",orc.idOrcamento); 
            Comando.Parameters.AddWithValue("@qtdPessoas",orc.qtdPessoas); 
            Comando.Parameters.AddWithValue("@sub",orc.sub);
            Comando.Parameters.AddWithValue("@iluminacao",orc.iluminacao);
            Comando.Parameters.AddWithValue("@mensagem",orc.mensagem);
            Comando.Parameters.AddWithValue("@dataEvento",orc.dataEvento);
            Comando.ExecuteNonQuery();               
            Conexao.Close();
        }
        
        public void Excluir(Orcamento orc){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();        
            String Query = "DELETE FROM Orcamento WHERE idOrcamento=@idOrcamento";
            MySqlCommand Comando =  new MySqlCommand(Query,Conexao); 
            Comando.Parameters.AddWithValue("@idOrcamento",orc.idOrcamento);
            Comando.ExecuteNonQuery();                        
            Conexao.Close();
        } 
    }
}
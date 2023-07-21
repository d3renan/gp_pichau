using gp_pichau.model;
using gp_pichau.view;
using System.Data;
using System.Data.SqlClient;


namespace gp_pichau.controller
{
    internal class manipulaPecas
    {
        public void cadPecas()
        {
            //Comando lê de baixo para cima
            SqlConnection cn = new SqlConnection(conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pcadastroPecas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("Pecas", classPecas.Peca);
                cmd.Parameters.AddWithValue("Marcas", classPecas.Marca);
                cmd.Parameters.AddWithValue("Capacidade", classPecas.Capacidade);

                SqlParameter nv = cmd.Parameters.Add("idPecas", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Peça cadastrada com sucesso, Deseja cadastrar outra peça?",
                    "Novo registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    Cadastrar telaCadastrar = new Cadastrar();
                    telaCadastrar.abrirCadastro();
                }
                else
                {
                    return;
                }
               
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void buscPecas()

        {
            SqlConnection cn = new SqlConnection(conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pbuscarPecasCodigo", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdPecas", classPecas.Codigo);
                cn.Open();
                var registros = cmd.ExecuteReader();

                if (registros.Read())
                {
                    classPecas.Codigo = Convert.ToInt32(registros["IdPecas"]);
                    classPecas.Peca = (string)registros["Pecas"];
                    classPecas.Marca = (string)registros["Marcas"];
                    classPecas.Capacidade = (string)registros["Capacidade"];
                }
                else
                {
                    classPecas.Codigo = 0;
                    classPecas.Peca = "";
                    classPecas.Marca = "";
                    classPecas.Capacidade = "";
                    MessageBox.Show("Peça não encontrada");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void deletPeca()
        {
            SqlConnection cn = new SqlConnection(conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pdeletarPecas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdPecas", classPecas.Codigo);
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Peça deletada com sucesso, deseja deletar outra ?",
                    "Deletar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    deletarPeca telaDeletar = new deletarPeca();
                    telaDeletar.AbrirDeletar();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void alterPeca()
        {
            SqlConnection cn = new SqlConnection(conexao.Conectar());
            SqlCommand cmd = new SqlCommand("palterarPeca", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdPecas", classPecas.Codigo);
                cmd.Parameters.AddWithValue("@Pecas", classPecas.Peca);
                cmd.Parameters.AddWithValue("@Marcas", classPecas.Marca);
                cmd.Parameters.AddWithValue("@Capacidade", classPecas.Capacidade);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Peça alterada com sucesso");

                classPecas.Codigo = 0;
                classPecas.Peca = "";
                classPecas.Marca = "";
                classPecas.Capacidade = "";


            }
            catch (Exception)
            {

                throw;
            }
        }
       
    }
}

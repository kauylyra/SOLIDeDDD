using Dapper;
using ProjetoDeRotina.Domain.Entities;
using ProjetoDeRotina.Domain.Interfaces.Repository;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ProjetoRotina.Infra.Context
{
    public class ProjetoRotinaContext : IRepositoryBase
    {
        private string connectionString = "";
        public ProjetoRotinaContext()
        {
            connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Futebol;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }

        public Jogador Adicionar(Jogador jogador)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"INSERT INTO Jogador (Nome, Nome_Time, Estado, Salario) VALUES(@Nome, @Nome_Time, @Estado, @Salario)";
                dbConnection.Open();
                dbConnection.Execute(sQuery, jogador);
            }
            return jogador;
        }

        public Jogador Alterar(Jogador jogador)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"UPDATE Jogador SET Nome = 'Jogador Alterado', Nome_Time = 'Nome do time Alterado', Estado = 'Estado Alterado', Salario = 500.00 WHERE ID_Jogador = 20";
                dbConnection.Open();
                dbConnection.Query(sQuery, jogador);
            }
            return jogador;
        }

        public void Remover(decimal id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"DELETE FROM Jogador WHERE ID_Jogador = 20";
                dbConnection.Open();
                dbConnection.Execute(sQuery, new { ID_Jogador = id });
            }
        }

        public Jogador ObterJogador()
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM Jogador";
                dbConnection.Open();
                return dbConnection.Query<Jogador>(sQuery);
            }
        }

        public Jogador ObterPorId(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM Jogador WHERE ID_Jogador = @ID_Jogador";
                dbConnection.Open();
                return dbConnection.Query<Jogador>(sQuery, new { ID_Jogador = id }).FirstOrDefault();
            }
        }



        public void Dispose()
        { }
    }
}

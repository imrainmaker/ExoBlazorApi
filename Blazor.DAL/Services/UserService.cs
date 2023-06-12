using Blazor.DAL.Context;
using Blazor.DAL.Dtos;
using Blazor.DAL.Entities;
using Blazor.DAL.Enum;
using Blazor.DAL.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using System.Data;
using System.Data.Common;

namespace Blazor.DAL.Services
{
    public class UserService : IUserRepository
    {
        private readonly DataContext _service;
        private readonly IDbConnection _dbConnection;

        public UserService(DataContext service, IDbConnection dbConnection)
        {
            _service = service;
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            List<User>? user = await _service.Users.ToListAsync();
            return user;
        }

        public async Task<User> AddUser(UserDto userDto)
        {
            using (SqlConnection sql = new SqlConnection(_dbConnection.ConnectionString))
            {
                using (SqlCommand cmd = sql.CreateCommand())
                {

                    User? utilisateur= null;
                    cmd.CommandText = "[dbo].[NewUser]";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@mail", userDto.Email);
                    cmd.Parameters.AddWithValue("@nom", userDto.Nom);
                    cmd.Parameters.AddWithValue("@prenom", userDto.Prenom);
                    cmd.Parameters.AddWithValue("@passwd", userDto.Password);

                    sql.Open();

                    using (DbDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            int id = (int)reader["Id"];
                            string email = (string)reader["Email"];
                            string nom = (string)reader["Nom"];
                            string prenom = (string)reader["Prenom"];
                            RoleEnum role = (RoleEnum)reader["Role"];

                            utilisateur = new User
                            {
                                Id = id,
                                Email = email,
                                Nom = nom,
                                Prenom = prenom,
                                Role = role
                            };
                        }
                    }

                    sql.Close();

                    return utilisateur is not null ? utilisateur : null;
                };

            }
    
        }
    }
}

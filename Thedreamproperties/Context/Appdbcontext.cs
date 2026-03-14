using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.Data.SqlClient;
using Thedreamproperties.Models;
using System;

namespace Thedreamproperties.Context
{
    public class Appdbcontext : DbContext
    {

        public Appdbcontext(DbContextOptions<Appdbcontext> options) : base(options) {

        }
        public DbSet<Contactmessege> contact_messege { get; set; }

        //create messege for stored procedure calling
        public async Task SaveContactmessegeasync(string name,string email,string subject,string messege)
        {
            var parameters = new[]
            {
                new SqlParameter("@name",
                                 name),
                new SqlParameter("@email",
                                 email),
                new SqlParameter("@subject", subject),
                new SqlParameter("@messege", messege)
              

            };
            await Database.ExecuteSqlRawAsync("EXEC insert_contact_messege @name,@email,@subject,@messege  ", parameters);
        }

    }
}

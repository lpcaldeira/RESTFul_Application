using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RESTFul_Application.Models
{
    public class Context : DbContext
    {
        public Context() : base("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\×Leonardo\\Documents\\RESTFulAPP.mdf;Integrated Security=True;Connect Timeout=30")
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
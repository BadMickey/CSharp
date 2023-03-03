using Microsoft.EntityFrameworkCore;
using MinhaPrimeiraAPI.Data.Map;
using MinhaPrimeiraAPI.Models;

namespace MinhaPrimeiraAPI.Data
{
    public class SistemasTarefasBDContex : DbContext
    {
        public SistemasTarefasBDContex(DbContextOptions<SistemasTarefasBDContex> options)
            : base(options)
        {

        }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}

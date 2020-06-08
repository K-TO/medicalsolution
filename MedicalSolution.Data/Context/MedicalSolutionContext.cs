using MedicalSolution.Infraestructure;
using Microsoft.EntityFrameworkCore;

namespace MedicalSolution.Data.Context
{
    public class MedicalSolutionContext : DbContext
    {
        public MedicalSolutionContext(DbContextOptions<MedicalSolutionContext> options) : base(options)
        {
        }

        DbSet<Hospital> Hospital { get; set; }
        DbSet<Especialidad> Especialidad { get; set; }
        DbSet<Doctor> Doctor { get; set; }
        DbSet<Paciente> Paciente { get; set; }
        DbSet<PacienteDoctor> PacienteDoctor { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MedicalSolutionContext).Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
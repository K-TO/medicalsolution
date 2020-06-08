using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MedicalSolution.Infraestructure;

namespace MedicalSolution.Data.Mapping
{
    /// <summary>
    /// Represents a patient mapping configuration
    /// </summary>
    public partial class PacienteMap : MedicalEntityTypeConfiguration<Paciente>
    {
        #region Methods
        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.ToTable(nameof(Paciente));
            builder.HasKey(patient => patient.Id);

            builder.Property(patient => patient.Nombres).IsRequired().HasMaxLength(50);
            builder.Property(patient => patient.Apellidos).IsRequired().HasMaxLength(50);
            builder.Property(patient => patient.Direccion).IsRequired().HasMaxLength(50);
            builder.Property(patient => patient.Telefono).IsRequired().HasMaxLength(20);
            builder.Property(patient => patient.NumeroSeguro).IsRequired().HasMaxLength(20);
            builder.Property(patient => patient.CodigoPostal).IsRequired().HasMaxLength(10);

            base.Configure(builder);
        }
        #endregion
    }
}

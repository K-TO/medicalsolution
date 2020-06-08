using MedicalSolution.Infraestructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalSolution.Data.Mapping
{
    /// <summary>
    /// Represents a patient doctor mapping configuration
    /// </summary>
    public partial class PacienteDoctorMap : MedicalEntityTypeConfiguration<PacienteDoctor>
    {
        #region Methods
        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<PacienteDoctor> builder)
        {
            builder.ToTable("Paciente_Doctor");

            builder.HasKey(docpat => docpat.Id);

            builder.Property(docpat => docpat.Id).IsRequired();
            builder.Property(docpat => docpat.DoctorId).IsRequired();
            builder.Property(docpat => docpat.PacienteId).IsRequired();


            builder.HasOne(docpat => docpat.Paciente)
                .WithMany()
                .HasForeignKey(docpat => docpat.PacienteId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(docpat => docpat.Doctor)
               .WithMany()
               .HasForeignKey(docpat => docpat.DoctorId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);

            base.Configure(builder);
        }
        #endregion
    }
}

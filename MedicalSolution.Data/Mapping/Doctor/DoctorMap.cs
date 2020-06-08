using MedicalSolution.Infraestructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalSolution.Data.Mapping
{
    /// <summary>
    /// Represents a doctor mapping configuration
    /// </summary>
    public partial class DoctorMap : MedicalEntityTypeConfiguration<Doctor>
    {
        #region Methods
        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.ToTable(nameof(Doctor));

            builder.HasKey(doctor => doctor.Id);

            builder.Property(doctor => doctor.Id).IsRequired().HasMaxLength(50);
            builder.Property(doctor => doctor.Nombres).IsRequired().HasMaxLength(50);
            builder.Property(doctor => doctor.Apellidos).IsRequired().HasMaxLength(50);
            builder.Property(doctor => doctor.Credencial).IsRequired().HasMaxLength(20);

            builder.HasOne(doctor => doctor.Hospital)
                .WithMany()
                .HasForeignKey(doctor => doctor.HospitalId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(doctor => doctor.Especialidad)
               .WithMany()
               .HasForeignKey(doctor => doctor.EspecialidadId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Cascade);

            base.Configure(builder);
        }
        #endregion
    }
}

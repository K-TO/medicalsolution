using MedicalSolution.Infraestructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalSolution.Data.Mapping
{
    /// <summary>
    /// Represents a hospital mapping configuration
    /// </summary>
    public partial class HospitalMap : MedicalEntityTypeConfiguration<Hospital>
    {
        #region Methods
        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<Hospital> builder)
        {
            builder.ToTable("gen_Hospital");
            builder.HasKey(especialidad => especialidad.Id);

            builder.Property(especialidad => especialidad.Nombre).IsRequired().HasMaxLength(50);
            builder.Property(especialidad => especialidad.Direccion).HasMaxLength(50);

            base.Configure(builder);
        }
        #endregion
    }
}

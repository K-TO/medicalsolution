using MedicalSolution.Infraestructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalSolution.Data.Mapping
{
    /// <summary>
    /// Represents a especialidad mapping configuration
    /// </summary>
    public partial class EspecialidadMap : MedicalEntityTypeConfiguration<Especialidad>
    {
        #region Methods
        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<Especialidad> builder)
        {
            builder.ToTable("gen_Especialidad");
            builder.HasKey(especialidad => especialidad.Id);

            builder.Property(especialidad => especialidad.Nombre).IsRequired().HasMaxLength(50);

            base.Configure(builder);
        }
        #endregion
    }
}

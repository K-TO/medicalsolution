namespace MedicalSolution.Infraestructure.Data
{
    /// <summary>
    /// Default entity identifier
    /// </summary>
    public abstract partial class BaseEntity
    {
        /// <summary>
        /// Gets or sets the entity identifier
        /// </summary>
        public int Id { get; set; }
    }
}
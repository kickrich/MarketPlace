namespace MarketPlace.Domain.Entities
{
    /// <summary>
    /// Сущность - файл
    /// </summary>
    public class File
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Дата создания.
        /// </summary>
        public DateTime Created { get; set; }
        /// <summary>
        /// Контент.
        /// </summary>
        public byte[] Content { get; set; } = null!;
        /// <summary>
        /// Тип контента.
        /// </summary>
        public string? ContentType { get; set; }
        /// <summary>
        /// Размер файла.
        /// </summary>
        public int Length { get; set; }
    }
}

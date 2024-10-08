namespace MarketPlace.Domain.Entities
{
    /// <summary>
    /// Сущность - категория
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Id родителя
        /// </summary>
        public Guid ParentId { get; set; }
        /// <summary>
        /// Название
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// Список объявлений
        /// </summary>
        public virtual List<Advert>? Adverts { get; set; }
    }
}

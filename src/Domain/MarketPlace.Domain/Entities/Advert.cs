using MarketPlace.Contracts.Enums;

namespace MarketPlace.Domain.Entities
{
    /// <summary>
    /// Сущность - объявление
    /// </summary>
    public class Advert
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Заголовок
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// Id категории
        /// </summary>
        public Guid CategoryId { get; set; }
        /// <summary>
        /// Ссылка на категорию
        /// </summary>
        public virtual Category? Category { get; set; }
        /// <summary>
        /// Статус объявления
        /// </summary>
        public AdvertStatus AdvertStatus { get; set; } = 0;
    }
}

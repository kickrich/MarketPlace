namespace MarketPlace.Contracts.Adverts
{
    public class AdvertCreateModel
    {
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
    }
}

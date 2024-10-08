namespace MarketPlace.Contracts.Users
{
    public class UserInfoModel
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Почта
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// День рождения
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; } = null!;
        /// <summary>
        /// Номер телефона
        /// </summary>
        public string? PhoneNumber { get; set; }
    }
}

namespace MarketPlace.Contracts.Users
{
    public class UserRegisterRequestDto
    {
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
        /// Пароль
        /// </summary>
        public string Password { get; set; } = null!;
        /// <summary>
        /// Номер телефона
        /// </summary>
        public string? PhoneNumber { get; set; }
    }
}

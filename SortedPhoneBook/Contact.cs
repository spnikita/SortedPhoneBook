namespace SortedPhoneBook
{
    /// <summary>
    /// Контакт телефонной книги
    /// </summary>
    internal class Contact
    {
        /// <summary>
        /// Параметризированный конструктор
        /// </summary>
        /// <param name="name"><inheritdoc cref="Name" path="/summary"/></param>
        /// <param name="lastName"><inheritdoc cref="LastName" path="/summary"/></param>
        /// <param name="phoneNumber"><inheritdoc cref="PhoneNumber" path="/summary"/></param>
        /// <param name="email"><inheritdoc cref="Email" path="/summary"/></param>
        public Contact(string name, string lastName, long phoneNumber, string email)
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; }

        /// <summary>
        /// Номер телефона
        /// </summary>
        public long PhoneNumber { get; }

        /// <summary>
        /// Почта
        /// </summary>
        public string Email { get; }
    }
}

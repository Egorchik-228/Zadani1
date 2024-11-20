using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    // Класс представляет читателя библиотеки
    public class Reader
    {
        // Уникальный идентификатор читателя
        public string Id { get; set; }

        // Имя читателя
        public string Name { get; set; }

        // Электронная почта читателя
        public string Email { get; set; }

        // Переопределение метода ToString для удобного вывода информации о читателе
        public override string ToString()
        {
            return $"ID: {Id}, Имя: {Name}, Электронная почта: {Email}";
        }
    }
}

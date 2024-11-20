using System;
using System.Collections.Generic;
using LibraryManagement.Models;

namespace LibraryManagement.Managers
{
    // Класс управляет коллекцией читателей
    public class ReaderManager
    {
        // Список читателей библиотеки
        public List<Reader> Readers { get; private set; }

        // Конструктор инициализирует пустой список читателей
        public ReaderManager()
        {
            Readers = new List<Reader>();
        }

        // Метод добавляет читателя в список
        public void AddReader(Reader reader)
        {
            if (reader == null) // Проверка, что читатель не null
                throw new ArgumentNullException(nameof(reader), "Читатель не может быть null.");

            if (Readers.Exists(r => r.Id == reader.Id)) // Проверка, что ID читателя уникален
                throw new InvalidOperationException($"Читатель с ID {reader.Id} уже существует.");

            Readers.Add(reader); // Добавление читателя в список
        }

        // Метод удаляет читателя по его ID
        public void RemoveReader(string readerId)
        {
            var reader = GetReader(readerId); // Поиск читателя по ID
            if (reader == null) // Проверка, что читатель существует
                throw new KeyNotFoundException($"Читатель с ID {readerId} не найден.");

            Readers.Remove(reader); // Удаление читателя из списка
        }

        // Метод возвращает читателя по его ID
        public Reader GetReader(string readerId)
        {
            return Readers.Find(r => r.Id == readerId); // Поиск читателя по ID
        }

        // Метод возвращает список всех читателей
        public List<Reader> GetAllReaders()
        {
            return Readers;
        }
    }
}
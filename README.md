Для работы программы требуется конфигурационный JSON-файл. Уже готовый вариант представлен в папке проекта Console. Путь к файлу программа запрашивает в самом начале.

# Формат содержимого конфигурационного файла:
{
  "Task1": {
    "RandomNumbersCount": int
  },
  "Task2": {
    "SourceText": string
  },
  "Task3": {
    "TemperatureInCelsius": double
    "ConvertTo": "Kelvin" || "Fahrenheit"
  },
  "Task4": {
    "Hours": double,
    "Minutes": double
  }
}

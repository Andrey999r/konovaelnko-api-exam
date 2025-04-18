
---

## 🧾 Описание

REST API для управления задачами: создание, просмотр, обновление и удаление задач в проекте.

API использует временное хранение данных (в памяти) и предназначен для демонстрации CRUD-операций с использованием ASP.NET Core Web API. Имеет встроенную валидацию и автогенерируемую документацию Swagger.

---

## 📦 Зависимости

- [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- ASP.NET Core Web API
- [Swashbuckle.AspNetCore](https://www.nuget.org/packages/Swashbuckle.AspNetCore) – для Swagger UI

### Установка зависимостей (внутри проекта):

```bash
dotnet restore
```

Если нужно вручную добавить Swagger:

```bash
dotnet add package Swashbuckle.AspNetCore
```

---

## 🚀 Запуск приложения

1. Клонируйте репозиторий:
```bash
git clone [вставить ссылку]
cd api_exam
```

2. Восстановите зависимости:
```bash
dotnet restore
```

3. Запустите приложение:
```bash
dotnet run
```

4. Перейдите по адресу:
- `http://localhost:5000/swagger` — Swagger UI
- `http://localhost:5000/tasks` — доступ к API

> 🔐 HTTPS по умолчанию также доступен на `https://localhost:5001`

---

## 🧪 Тестирование

### Postman Collection:

1. Открыть [Postman](https://www.postman.com/)
2. Импортировать коллекцию из `/postman/api_exam.postman_collection.json`
3. Выполнить тесты:
   - `GET /tasks`
   - `POST /tasks`
   - `PUT /tasks/{id}`
   - `DELETE /tasks/{id}`
4. Скриншоты тестов находятся в папке `screenshots/`

---

## 📄 Структура проекта

```
api_exam/
├── Controllers/
│   └── TasksController.cs     # CRUD-методы API
├── Models/
│   └── TaskItem.cs            # Модель и валидация задачи
├── Program.cs                 # Запуск и конфигурация
├── Properties/
│   └── launchSettings.json    # Настройки среды выполнения
├── api_exam.csproj            # Файл проекта
├── postman/
│   └── api_exam.postman_collection.json
└── screenshots/
    ├── post_success.png
    ├── post_fail.png
    └── put_success.png
```

---

## 🔐 Примеры запросов

**POST /tasks**
```json
{
  "title": "Новая задача",
  "description": "Описание",
  "status": "New"
}
```

**PUT /tasks/1**
```json
{
  "title": "Обновлено",
  "description": "Обновлённое описание",
  "status": "Done"
}
```

---

## 📄 Swagger документация

Swagger UI автоматически доступен после запуска по адресу:

```txt
http://localhost:5000/swagger
```

Позволяет отправлять запросы прямо из браузера и видеть модель данных.


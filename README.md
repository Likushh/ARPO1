# Лабораторная работа №1. АРПО

## Цель

Настроить автоматическую сборку Unity-проекта под WebGL через CLI.

## Используемые инструменты

- Unity Hub
- Unity 6000.2.10f1
- Шаблон 2D (Universal)
- Git, GitHub
- VS Code + Live Server

## Шаг 1. Создание проекта

Создан проект

## Шаг 2. Скрипт BuildManager.cs

Код: Assets/Editor/BuildManager.cs
Скриншот меню CI/CD → Build WebGL: ![alt text](screenshots/152906.png)

## Шаг 3. Отключение сжатия WebGL

Compression Format = Disabled.
Скриншот: ![alt text](screenshots/154217.png)

## Шаг 4. CLI-сборка

Команда:

```powershell
& "D:\Unity\Hub\Editor\6000.2.10f1\Editor\Unity.exe" -batchmode -nographics -executeMethod BuildManager.BuildWebGL -quit -logFile build_webgl.log
```

Скриншот терминала: ![alt text](screenshots/154633.png)

## Шаг 5. Результат сборки

В логе найдено:

```
[CI/CD] УСПЕХ! WebGL билд успешно создан.
```

Скриншот: ![alt text](screenshots/image.png)

## Шаг 6. Локальный запуск

Запущено через Live Server.
Скриншот игры: ![alt text](screenshots/164243.png)

## Шаг 7. Git

Ветки: main, LR1.
Скриншот: ![alt text](screenshots/image-1.png)

## Шаг 8. Pull Request

PR из LR1 в main.
Скриншоты: ![alt text](screenshots/image-2.png) ![alt text](screenshots/image-3.png) ![alt text](screenshots/image-4.png)

## Вывод

В ходе работы настроена автоматическая сборка Unity WebGL через CLI.

## Лабораторная работа №2. CI/CD через GitHub Actions

### Шаг 1. Резервный репозиторий

![Резервный репозиторий] ![alt text](screenshots/092731.png)

### Шаг 2. PAT-токен

![Настройки PAT]![alt text](screenshots/093019.png)

### Шаг 3. Секрет BACKUP_TOKEN

![Секрет] ![alt text](screenshots/093457.png)

### Шаг 4. YAML-пайплайн

Файл: `.github/workflows/main.yml`
![YAML](screenshots/094115.png)

### Шаг 5. Pull Request

![alt text](screenshots/094421.png)
![alt text](screenshots/094524.png)
![alt text](screenshots/094603.png)

### Шаг 6. Запуск workflow

![alt text](screenshots/094806.png)

### Шаг 7. Зеркалирование

![alt text](screenshots/094916.png)

### Вывод

Настроен CI/CD пайплайн GitHub Actions: sanity check структуры проекта и автоматическое зеркалирование кода в резервный репозиторий через PAT-токен.

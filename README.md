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
Скриншот меню CI/CD → Build WebGL: ![alt text](<Снимок экрана 2026-09-28 152906.png>)

## Шаг 3. Отключение сжатия WebGL

Compression Format = Disabled.
Скриншот: ![alt text](<Снимок экрана 2026-09-28 154217.png>)

## Шаг 4. CLI-сборка

Команда:

```powershell
& "D:\Unity\Hub\Editor\6000.2.10f1\Editor\Unity.exe" -batchmode -nographics -executeMethod BuildManager.BuildWebGL -quit -logFile build_webgl.log
```

Скриншот терминала: ![alt text](<Снимок экрана 2026-09-28 154633.png>)

## Шаг 5. Результат сборки

В логе найдено:

```
[CI/CD] УСПЕХ! WebGL билд успешно создан.
```

Скриншот: ![alt text](image.png)

## Шаг 6. Локальный запуск

Запущено через Live Server.
Скриншот игры: ![alt text](<Снимок экрана 2026-09-28 164243.png>)

## Шаг 7. Git

Ветки: main, LR1.
Скриншот: ![alt text](image-1.png)

## Шаг 8. Pull Request

PR из LR1 в main.
Скриншоты: ![alt text](image-2.png) ![alt text](image-3.png) ![alt text](image-4.png)

## Вывод

В ходе работы настроена автоматическая сборка Unity WebGL через CLI.

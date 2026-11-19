# Шаг 1: Берем официальный ультра-легкий веб-сервер Nginx на базе Alpine Linux
FROM nginx:alpine

# Шаг 2: Удаляем дефолтный файл настроек Nginx
RUN rm /etc/nginx/conf.d/default.conf

# Шаг 3: Копирование кастомного nginx.conf
COPY nginx.conf /etc/nginx/conf.d/

# Шаг 4: Очищаем стандартную веб-папку и копируем туда файлы игры
RUN rm -rf /usr/share/nginx/html/*
COPY Builds/WebGL/ /usr/share/nginx/html/

# Шаг 5: Объявляем рабочий порт контейнера
EXPOSE 80

# Шаг 6: Запускаем Nginx
CMD ["nginx", "-g", "daemon off;"]
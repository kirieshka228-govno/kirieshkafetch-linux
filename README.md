<h1 align="center">
 kirieshkafetch (Linux)
</h1>

Пародия на fastfetch но без кастомизации

Открывается почти что моментально и отображает важную информацию о системе

## Установка

### Рекомендуемый способ (для новичков)

1. Зайди на страницу [релизов](https://github.com/kirieshka228-govno/kirieshkafetch-linux/releases)
2. Скачай файл kirieshkafetch
3. Зайди в директорию где лежит этот файл
4. Пропиши ``chmod +x kirieshkafetch`` (эта команда делает файл исполняемым)
5. Запусти его прописав ``./kirieshkafetch``
6. Готово!


### Сборка из исходников

1. Пропиши в терминале ``git clone https://github.com/kirieshka228-govno/kirieshkafetch-linux.git``
2. Зайди в VS Code
3. Нажми на File и на Open Folder
4. Найди и выбери папку kirieshkafetch-linux
5. Открой встроенный терминал (Terminal > New Terminal) и собери проект прописав ``dotnet publish -c Release -r linux-x64 -p:PublishSingleFile=true --self-contained true``
6. Если сборка выполнена без ошибок то переходи в директорию ``bin/Release/net10.0/linux-x64/publish/``, делай kirieshkafetch исполняемым, и запускай его командой ``./kirieshkafetch``
7. Готово! По желанию ты можешь перенести файл kirieshkafetch из папки publish в любое другое место

**P.S: Если надо запускать из любого места то пропиши команду ``sudo cp kirieshkafetch /usr/local/bin/``**

## Требования

* **ОС:** Linux x86_64

* **Процессор:** Любой

* **.NET 10 SDK (для сборки)**

## Скриншоты

<img width="953" height="579" src="https://github.com/user-attachments/assets/651a7295-039d-4ffb-b524-f4c3f5bb3e3b" />


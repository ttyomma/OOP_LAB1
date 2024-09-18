# Лабораторна робота №1 <br/>
Тема: основи технології Windows Forms.<br/>
Мета: розробити програми типу Windows Forms Application на мові C#.<br/>
<br/>
## Завдання №1 / Task 1
Створити додаток Windows Forms. Обчислити значення виразу, передбачивши обробку помилок та видачу відповідних повідомлень користувачу. Параметри виразу x, y, z задаються користувачем.<br/>
![image](https://github.com/user-attachments/assets/69032cf9-bca2-407b-a879-b5ddfdd4541f)<br/>
<br/>
Компіляція програми та її вигляд:<br/>
![image](https://github.com/user-attachments/assets/2ad87c11-420a-4036-aa24-b885bf30097c)<br/>
<br/>
## Завдання №2 / Task 2
Розробити програми типу Windows Forms відповідно до варіанту. Забезпечити перевірку на коректність введених даних, організувати зручний користувацький інтерфейс.<br/>
<br/>
Варіант 7: Розробити електронний калькулятор для виконання операцій *, /, % над цілими числами. Реалізувати можливість розрахунку математичних виразів з операціями в дужках, наприклад, шляхом введення користувачем виразів вигляду 20%(1+10/(3-1))<br/>
<br/>
Розробка програми:<br/>
Програма використовує найпростіший спосіб обрахунку введенних данних, а саме через клас DataTable та його метод Compute вбудований в .NET Framework. <br/> Метод Compute аналізує рядок з виразом та розбиває його на лексеми. В цьому випадку ми не реалізуємо логіку обчислення виразу самостійно. Такий підхід набагато простіший в реалізації, прпоте є менш гнучким, ніж ручна реалізація алгоритму обчислення.<br/>
<br/>
Використання в коді:<br/>
![image](https://github.com/user-attachments/assets/c0bb3725-6f45-41e2-8da1-a2f4b2620084)<br/>
<br/>
Компіляція програми та її вигляд:<br/>
![image](https://github.com/user-attachments/assets/202896d8-362d-448d-b118-fe0178bf204c)<br/>

## Додаткове завдання / Additional Task
Умова: Створити програмку клікер. Треба виводити статистику по клікам за певний період часу.<br/>

### Розробка програми:<br/>
Основні елементи:
1) Кнопка для кліків (buttonClick).
2) Label для відображення часу, що залишився (time).
3) Label для відображення кількості кліків (clicks).
4) Внутрішній таймер для відліку часу (gameTimer). 

### Логіка програми:
1) Гра починається після першого натиску на кнопку <br/>
2) Таймер запускається і починає відлік часу <br/>
3) Кожен клік на кнопку збільшує лічильник кліків <br/>
4) Коли час закінчується, гра зупиняється, відображається результат, і гру можна розпочати заново. <br/>
<br/>
Компіляція програми та її вигляд: <br/>

![image](https://github.com/user-attachments/assets/cc2198c0-e7fa-4809-9e47-1cf5dd55b0ed)<br/>

## Роз'яснення коду програми:
### Змінні для використання:<br/>
_gameTimer_: таймер, який керує часом гри.<br/>
_timeCount_: зберігає кількість секунд, що залишилися.<br/>
_clickCount_: кількість кліків гравця.<br/>
_gameStarted_: булева змінна, що вказує, чи гра запущена.<br/>

### Методи:
1) **Метод UpdateUI:**<br/>
 Оновлює текст для відображення на формі, відображаючи поточний час (timeCount) та кількість кліків (clickCount). Надалі робить кнопку "buttonClick" неактивною, якщо час вийшов (timeCount = 0).

3) **Метод StartGame:**<br/>
 Встановлює початкові значення для часу (15 секунд) та кількості кліків (0).<br/>
 Створює і налаштовує таймер (gameTimer): Інтервал оновлення: 1000 мілісекунд (1 секунда).<br/>
**При кожному тику таймера:**<br/>
  Зменшує час на 1 секунду.<br/>
  Оновлює інтерфейс.<br/>
  Перевіряє, чи час вийшов. Якщо так, викликає метод EndGame().<br/>
  Запускає таймер.<br/>
  Активує кнопку "buttonClick".<br/>
  
4) **Метод EndGame:**<br/>
  Зупиняє таймер.<br/>
  Показує повідомлення з результатом гри.<br/>
  Встановлює прапорець gameStarted у "false".<br/>
  Активує кнопку "buttonClick".<br/>

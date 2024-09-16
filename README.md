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


// Задание 1.1
// string[] days = {"Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс"};


// for (int i = days.Length - 1; i > -1; i--) {
//      Console.WriteLine($"{i+1}: {days[i]}");
// }


// задание 1.2
// double[] temps = [2.1, 3.5, 54.6, -23.3, 34.1, 434.6, -21.0];

// foreach (double i in temps) {
//     Console.Write($"{i} ");
// }


// Задание 2
// int[] prices = { 120, 45, 300, 80, 15, 210 };

// int sum = 0;
// int count_100 = 0;

// foreach (int i in prices) {
//     sum += i;
//     if (i > 100) {
//         count_100 += 1;
//     }
// }

// double sr = (double)sum / prices.Length;
// Console.WriteLine($"сумма: {sum}, средняя: {sr}, количество больше 100: {count_100}");

// задание 3
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int min = prices[0];
// int max = prices[0];
// int ind = 0;

// for (int i = 0; i < prices.Length; i++) {
//     if (prices[i] < min) {
//         min = prices[i];
//     }
//     if (prices[i] > max) {
//         max = prices[i];
//         ind = i;
//     }
// }
// Console.WriteLine($"{min}, {ind}");


// задание 4
// int[] balance = { 100, -50, 20, -5, 0, 75 };

// for (int i = 0; i < balance.Length; i++) {
//     if (balance[i] < 0) {
//         balance[i] = 0;
//     }
// }

// foreach (int j in balance) {
//     Console.WriteLine(j);
// }

// задание 5
// int[] masiv = new int[5];
// int count = 0;

// for (int i = 0; i < masiv.Length; i++) {
//     masiv[i] = int.Parse(Console.ReadLine());
// }

// for (int i = masiv.Length - 1; i > -1; i--) {
//     if (masiv[i] % 2 == 0) {
//         count += 1;
//     }
//     Console.WriteLine(masiv[i]);
// }
// Console.WriteLine(count);

// Задание 6

// string[] names = { "Анна", "Игорь",
// "Мария", "Олег", "Ольга" };

// Console.WriteLine("Введите имя");
// string name = Console.ReadLine().Trim().ToLower();
// int ind = -1;

// for (int i = 0; i < names.Length; i++) {
//     if (name == names[i].ToLower()) {
//         ind = i;
//         Console.WriteLine("adf");
//     }
// }

// if (ind > -1) {
//     Console.WriteLine(ind);
// } else {
//     Console.WriteLine("Не найдено");
// }

// Итоговая задача
// int[] grades = [2, 3, 5, 3, 4, 5, 3, 2];
// int sum = 0;
// int max = grades[0];
// int min = grades[0];
// int count2 = 0;
// int count5 = 0;

// for (int i = 0; i < grades.Length; i++) {
//     sum += grades[i];
//     if (grades[i] > max) {
//         max = grades[i];
//     }
//     if (grades[i] < min) {
//         min = grades[i];
//     }
//     if (grades[i] == 2) {
//         count2 += 1;
//     }
//     if (grades[i] == 5) {
//         count5 += 1;
//     }
//     Console.Write($"{grades[i]} ");
// }

// double sr = (double)sum / grades.Length;

// Console.WriteLine($"среднее: {sr}, мин: {min}, макс: {max}, количество 2: {count2}, колво 5: {count5}");

// if (sr >= 4.5) {
//     Console.WriteLine("Отличник");
// } else if (sr >= 3.5) {
//     Console.WriteLine("Хорошист");
// } else {
//     Console.WriteLine("Есть над чем поработать");
// }

//Доп задание
int[] arr = { 1, 2, 3, 4, 5, 6 };
for (int i = 0; i < arr.Length/2; i++) {
    int a = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = a;
    
}

foreach (int i in arr) {
    Console.WriteLine(i);
}
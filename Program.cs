// string myname = "Макар";
// string groupname = "ИСП-252";
// int coursenumber = 2;
// double averageGrade = 4.5;
// bool isStudent = false;


// Console.WriteLine($"Студент: {myname}");
// Console.WriteLine($"Имя группы: {groupname}");
// Console.WriteLine($"Курс: {coursenumber}");
// Console.WriteLine($"Средний балл: {averageGrade}");
// Console.WriteLine($"Булево: {isStudent}");


// string firstName = "Захар";
// string lastName = "Сокур";
// string fullNameContact = firstName + " " + lastName;
// string fullNameIne = $"{firstName} {lastName}";
// string fullNameConcatMethod = string.Concat(firstName, " ", lastName);
// Console.WriteLine($"Name: {fullNameContact}");
// Console.WriteLine($"Name: {fullNameIne}");
// Console.WriteLine($"Name: {fullNameConcatMethod}");

// System.Console.WriteLine();
// const double VatRate = 0.2;
// const string CollageName = "ВФ";
// Console.WriteLine($"Rate: {VatRate}");
// Console.WriteLine($"College: {CollageName}");

// System.Console.WriteLine("Ремонт комнаты");
// double roomWhidth = 3.5;
// double roomLenth = 4.2;
// double roomS = roomWhidth * roomLenth;
// double roomP = (roomLenth + roomWhidth) * 2;

// Console.WriteLine($"Ширина: {roomWhidth}");
// Console.WriteLine($"Длина: {roomLenth}");
// Console.WriteLine($"S: {roomS}");
// Console.WriteLine($"P: {roomP}");

// System.Console.WriteLine();
// Console.WriteLine("Покупка ноутбука в рассрочку");

// int laptopPrice = 65000;
// int monthsCount = 12;
// double interestRate = 0.08;

// double totalWithInterest = laptopPrice * (1 + interestRate);
// double monthlyPayment = totalWithInterest / monthsCount;

// Console.WriteLine($"Цена ноутбука: {laptopPrice} руб.");
// Console.WriteLine($"Итого с процентами: {totalWithInterest} руб.");
// Console.WriteLine($"Платеж в месяц: {monthlyPayment} руб.");

// Console.WriteLine();
// Console.WriteLine("Внимание: деление int");

// int totalStudents = 25;
// int groupsC = 4;
// int studentsGroupWrong = totalStudents / groupsC;
// double studentsPerGroupCorrect = (double)totalStudents / groupsC;

// Console.WriteLine($"25 / 4 как int: {studentsGroupWrong}");
// Console.WriteLine($"25 / 4 как double: {studentsGroupCorrect}");

// Объединяем строки разными способами
Console.WriteLine();
Console.WriteLine("Способы собрать строку");

// Переменные для имени и фамилии
string firstName = "Анна";
string lastName = "Смирнова";

// Способ 1: склеиваем через плюс
string fullNameConcat = firstName + " " + lastName;

// Способ 2: используем интерполяцию через $
string fullNameInterp = $"{firstName} {lastName}";

// Способ 3: используем готовый метод string.Concat
string fullNameConcatMethod = string.Concat(firstName, " ", lastName);

// Выводим все варианты на экран
Console.WriteLine(fullNameConcat);
Console.WriteLine(fullNameInterp);
Console.WriteLine(fullNameConcatMethod);

// Проверяем, совпадает ли результат всех трех способов
Console.WriteLine($"Все три строки равны: {fullNameConcat == fullNameInterp && fullNameInterp == fullNameConcatMethod}");


// Работаем с фиксированными значениями (константами)
Console.WriteLine();
Console.WriteLine("Константы");

// Константы — эти значения нельзя случайно изменить дальше в коде
const double VatRate = 0.20;
const string CollegeName = "ВФ ВолГУ";

// Считаем итоговую цену вместе с НДС
double productPrice = 1000;
double priceWithVat = productPrice * (1 + VatRate);

// Выводим название заведения и итоговую цену
Console.WriteLine($"Учебное заведение: {CollegeName}");
Console.WriteLine($"Цена без НДС: {productPrice}, с НДС ({VatRate:P0}): {priceWithVat}");



// // Задание 1. Финансовый мини-расчёт
// Console.WriteLine("Финансовый расчёт");

// int scholarship = 5000;
// int monthlyExpen = 3500;

// int monthlyBal = scholarship - monthlyExpen;

// const int MonthsSemester = 4;

// int semesterBalance = monthlyBal * MonthsSemester;

// Console.WriteLine($"Стипендия: {scholarship} руб.");
// Console.WriteLine($"Расходы: {monthlyExpen} руб.");
// Console.WriteLine($"Остаток за месяц: {monthlyBal} руб.");
// Console.WriteLine($"Остаток за семестр: {semesterBalance} руб.");

// Console.WriteLine();



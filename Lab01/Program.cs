// string myName = "Тимофей Колосков";
// string groupName = "ИСП-253";
// int courseNumber = 2;
// double averageGrade = 4.6;
// bool isBudget = true;

// Console.WriteLine("Знакомство");
// Console.WriteLine($"Студент: {myName}");
// Console.WriteLine($"Группа: {groupName}");
// Console.WriteLine($"Курс: {courseNumber}");
// Console.WriteLine($"Средний балл: {averageGrade}");
// Console.WriteLine($"Бюджетное место: {isBudget}");

// // программа производит расчёт площади, периметра и ширины комнаты на основе введённых в неё данных

// Console.WriteLine();
// Console.WriteLine("Ремонт: комната");

// double roomWidth = 3.5;
// double roomLength = 4.2;

// double roomArea = roomWidth * roomLength;
// double roomPerimeter = (roomWidth + roomLength) * 2;

// Console.WriteLine($"Ширина: {roomWidth} м, длина: {roomLength} м");
// Console.WriteLine($"Площадь: {roomArea} кв.м");
// Console.WriteLine($"Периметр: {roomPerimeter} м");

// //  программа производит расчёт цены ноутбука, как отдельную так и с процентами, а также ежемесячный платёж на основе введённых в неё данных

// Console.WriteLine();
// Console.WriteLine("Покупка ноутбука в рассрочку");

// int laptopPrice = 65000;
// int monthsCount = 12;
// double interestRate = 0.08;

// double totalWithInterest = laptopPrice * (1 + interestRate);
// double monthlyPayment = totalWithInterest / monthsCount;

// Console.WriteLine($"Цена ноутбука: {laptopPrice} руб.");
// Console.WriteLine($"Итого с процентами: {totalWithInterest} руб.");
// Console.WriteLine($"Платёж в месяц: {monthlyPayment} руб.");



// Console.WriteLine();
// Console.WriteLine("Внимание: деление int");

// int totalStudents = 25;
// int groupsCount = 4;

// int studentsPerGroupWrong = totalStudents / groupsCount;
// double studentsPerGroupCorrect = (double)totalStudents / groupsCount;

// Console.WriteLine($"25 / 4 как int: {studentsPerGroupWrong}");
// Console.WriteLine($"25 / 4 как double: {studentsPerGroupCorrect}");

// // описание и практическое применение всех способов сбора строки
// Console.WriteLine();
// Console.WriteLine("Способы собрать строку");

// string firstname = "Анна";
// string lastname = "Смирнова";

// // Способ 1: конкатенация через оператор +
// string fullNameConcat = firstname + " " + lastname;

// // Способ 2: интерполяция через $""
// string fullNameInterp = $"{firstname} {lastname}";

// // Способ 3: метод string.Concat
// string fullNameConcatMethod = string.Concat(firstname, " ", lastname);

// Console.WriteLine(fullNameConcat);
// Console.WriteLine(fullNameInterp);
// Console.WriteLine(fullNameConcatMethod);
// Console.WriteLine($"Все три строки равны: {fullNameConcat == fullNameInterp && fullNameInterp == fullNameConcatMethod}");


// // принцип работы констант
// Console.WriteLine();
// Console.WriteLine("Константы");

// const double VatRate = 0.20;
// const string CollegeName = "ВФ Волгу";

// double productPrice = 1000;
// double priceWithVat = productPrice * (1 + VatRate);

// Console.WriteLine($"Учебное заведение: {CollegeName}");
// Console.WriteLine($"Цена без НДС: {productPrice}, с НДС ({VatRate:P0}):{priceWithVat}");


// int scholarship = 2000;
// int monthlyExpenses = 1500;
// int leftovers = scholarship - monthlyExpenses;
// Console.WriteLine($"Деньги оставшиеся под конец месяца: {leftovers}");
// const int MonthsInSemester = 4;
// int semleftov = leftovers * MonthsInSemester;
// Console.WriteLine($"Деньги оставшиеся под конец семестра: {semleftov}");


int totalMinutes = 500;
int minutesPerLesson = 45;
int lessonCount = totalMinutes / minutesPerLesson;
int procentCount = totalMinutes % minutesPerLesson;
Console.WriteLine($"{totalMinutes} минут = {lessonCount} полных занятий + {procentCount} минут");
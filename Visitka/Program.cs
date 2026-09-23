Console.WriteLine("Визитная карточка студента");
const string myName = "Тимофей Колосков";
const string groupName = "ИСП-253";
int courseNumber = 2;
double specialnost = 09.02;
int uchNedel = 17;

int ballSemestr1 = 5;
int ballSemestr2 = 3;
int ballSemestr3 = 4;

double ballEnd = (ballSemestr1 + ballSemestr2 + ballSemestr3) / 3;



Console.WriteLine("Знакомство");
Console.WriteLine($"Студент: {myName}");
Console.WriteLine($"Группа: {groupName}");
Console.WriteLine($"Курс: {courseNumber}");
Console.WriteLine($"Специальность: {specialnost}");
Console.WriteLine($"Средний балл: {ballEnd}");
Console.WriteLine($"Учебных недель: {uchNedel}");
if (ballEnd >= 4.5)
{
    Console.WriteLine("Стипендия положена");
}
else
{
    Console.WriteLine("Стипендия не положена");
}


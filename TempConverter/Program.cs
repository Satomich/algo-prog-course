const int A = 9/5;
const int B = 32;
const double C = 273.15;
const double celsius = 13.5;
Console.WriteLine($"Шкала цельсия: {celsius}");
double Farengeit = celsius  * A + B;
Console.WriteLine($"Расчёт по шкале Фаренгейта: {Farengeit}");
double Kelvin = celsius + C;
Console.WriteLine($"Расчёт по шкале Кельвина: {Kelvin}");

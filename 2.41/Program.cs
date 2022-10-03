
double m1, hour, minutes = 0;
Console.WriteLine("Введите угол в радианах :");
double alp = Convert.ToDouble(Console.ReadLine()); //ввод угла от 0 до 2*PI
alp = 180 / Math.PI; // перевод в градусы
hour = alp / 30.0; // целых часов, 30 градусов = 1 час
minutes = (alp - hour * 30) * 2;  // целых минут, 30 градусов = 60 минут
m1 = minutes * 6;  // угол одной минуты для часовой стрелки = 6 градусам
Console.WriteLine("Houer " + hour );
Console.WriteLine("Minutes = " + minutes);
 Console.WriteLine("Min len ="  +m1)  ;

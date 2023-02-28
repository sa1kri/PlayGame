// See https://aka.ms/new-console-template for more information
Console.WriteLine("Привет игрок, ты попал в мир чюдес, но этот мир окутался злом.");
Console.WriteLine("Помоги нам его спасти.");

Console.WriteLine("----------------------------");

Console.WriteLine("Твой уровень магии: 1");
int ExpManna = 1;
Console.WriteLine("Твой уровень артефактами: 1");
int ExpArtefactami = 1;
Console.WriteLine("Твой уровень силы: 1");
int ExpSila = 1;

Console.WriteLine("----------------------------");

Console.WriteLine("Уровень 1");
Console.WriteLine("На вашем пути попался *Разбойник*: Уровень магии: 0, Уровень артефактов: $, Уровень силы: 1");
Console.WriteLine("Около него клетка накрыта тканем");
Console.WriteLine("Ваши действия 1)атоковать, 2)обойти мимо");

Console.WriteLine("----------------------------");

Console.Write("Выбор: ");
int variant_1 = Console.Read();

Console.WriteLine("----------------------------");

if (variant_1==1)
{
    Console.WriteLine("Вы одолели *Разбойника* ");
    ExpSila = ExpSila + 4;
    Console.WriteLine("Ваша сила", ExpSila, ExpManna, ExpArtefactami);
}
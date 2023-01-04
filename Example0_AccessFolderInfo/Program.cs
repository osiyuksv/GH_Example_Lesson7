// See https://aka.ms/new-console-template for more information

string path = "C:/Users/admin/Documents/ЦЗН Продукт менеджмент/01 Введение в программирование";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);

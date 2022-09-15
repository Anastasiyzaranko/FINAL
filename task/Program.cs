/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из
 строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с 
 клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
 пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string[,,] arr = new string[4,5,3] ;
string[] arr1 = {"Hello", "2", "world", ":-)"};
string[] arr2 = {"1234", "1567", "-2", "computer science"};
string[] arr3 = {"Russia", "Denmark", "Kazan"};
string[] newarr= new string[arr.Length];

for (int i=0; i<arr1.Length; i++)
{
    if(arr1[i].Length<=3)
    {        
        newarr[i]=arr1[i];;
        Console.WriteLine( newarr[i]); 
    }
}        

for (int i=0; i<arr2.Length; i++)
{
    if(arr2[i].Length<=3) 
    {        
        newarr[i]=arr2[i];;
        Console.WriteLine(newarr[i]); 
    }
}        
for (int i=0; i<arr3.Length; i++)
{
    if(arr3[i].Length<=3)
    {        
        newarr[i]=arr3[i];;
        Console.WriteLine(newarr[i]); 
    }
}        

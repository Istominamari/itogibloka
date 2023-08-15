// Написать программу, которая из имеющегося массива строк формирует массив
// из строк, длина которых меньше, либо равна 3 символа.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте
//выполнения алгоритма. При решениями не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами.


string[] array = new string[] { "hello", "2", "world", ":-)", "3", "a", "bb"};
string[] filtered = new string[array.Length];
int j = 0;

for (int i = 0; i < array.Length; i++) {
    if (array[i].Length <= 3)
    {
        filtered[j++] = array[i];
        
    }
}

string[] result = new string[j];
Array.Copy(filtered, result, j);

Console.WriteLine(String.Join(", ", result));



char [,] char_array = new char[2,5]{
{'w', 'o', 'r', 'l', 'd'},
{'h', 'e', 'l', 'l', 'o'}};

string str = "";
foreach(char el in char_array)
  str += el;
Console.WriteLine(str);


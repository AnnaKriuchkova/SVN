

string [] array ={ "ёж", "сова", "ель", "уж", "крот", "медведь", "заяц", "крот", "сом"};

int filteredcount = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
        {
            filteredcount ++;
        }
}
if (filteredcount == 0)
{
    Console.WriteLine("[]");
}
else
{
    string [] filteredArray = new string [filteredcount];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
        {
        if(array[i].Length <= 3)
        {
            filteredArray[index] = array[i];
            index = index+1;
        }
        }
    Console.WriteLine(String.Join(" ",filteredArray));
}


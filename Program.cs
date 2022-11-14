void InsertItem(ref string[] array, string value, int index) {
    string[] newArray = new string[array.Length + 1];

    newArray[index] = value;

    for (int i = 0; i < index; i++) {
        newArray[i] = array[i];
    }

    for (int i = index; i < array.Length; i++) {
        newArray[i + 1] = array[i];
    }

    array = newArray;
}

void filterArray (string[] array)

{
    string[] favoriteArray = { };
    int count = 0;

    for (int i = 0; i < array.GetLength(0); i++) {
        if (array[i].Length <= 3) {
            InsertItem(ref favoriteArray, array[i], count);
            count++;
        }
    }

    Console.Write(String.Join(", ", favoriteArray) );

}

string[] collections1 = { "hello", "2", "world", ":-)" };
string[] collections2 = { "1234", "1567", "-2", "computer science" };
string[] collections3 = { "Russia", "Denmark", "Kazan" };

filterArray(collections1);
filterArray(collections2);
filterArray(collections3);

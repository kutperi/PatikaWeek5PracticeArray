
int[] array = new int[10]; // Defining a new array and deciding length is 10

for (int i = 0; i < array.Length; i++) // Setting the array values with this formula below
{
    array[i] = i * 2;
}

Console.WriteLine("Array dizisinin elemanları: "); 

foreach (int i in array) // Displaying the array values
{
    Console.WriteLine(i);
}

// Asking user to set a new value for the array
Console.Write("Lütfen bu diziye eklemek istediğiniz 11. değerini giriniz: ");
int newElement = Convert.ToInt32(Console.ReadLine());

int[] newArray = new int[array.Length + 1]; // Since the array length is fixed and cannot be changed, I define a new array to add the 11th element.

for (int i = 0; i < array.Length; i++) // Setting the values of new array from first array
{
    newArray[i] = array[i];
}

newArray[newArray.Length - 1] = newElement; // Adding the 11th elemement

Console.WriteLine("Yeni yapılan dizinin elemanları: ");

foreach (int i in newArray) // Displaying the new array elements
{
    Console.WriteLine(i);
}


Array.Sort(newArray); // I used the Sort method to sort the elements of the array from small to large.
Array.Reverse(newArray); // And reversed.


Console.WriteLine("Büyükten küçüğe doğru sıralaması: ");

foreach (int i in newArray) // Displaying the elements in new order
{
    Console.WriteLine(i);
}
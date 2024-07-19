string[] names; // can reference any array of strings
// allocating memory for four strings in an array
names = new string[4];
// storing items at index positions
names[0] = "Kate";
names[1] = "Jack"; 
names[2] = "Rebecca"; 
names[3] = "Tom";
for (int i = 0; i < names.Length; i++) // looping through the names
{ // output the item at index position i
 Console.WriteLine(names[i]); 
}
// Arrays are useful for temporarily storing multiple items,
// collections are a more flexible option when adding and removing items dynamically
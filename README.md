# SelectionSort

This code is an implementation of the selection sort algorithm in C#. 
 The code first prompts the user to enter the number of elements in the array. It then creates an integer array of size n to store the elements. The user is then prompted to enter the elements of the array, separated by spaces. The input is read as a string and then split into individual elements using the Split() method.
 The code then uses a for loop to iterate through each element in the input string array. It attempts to parse each element as an integer using int.TryParse(). If the parsing is successful, the element is stored in the integer array.
 After the array is populated with the user input, the Sort() method is called to perform the selection sort algorithm on the array.
 The Sort() method first checks if the input array is null or empty. If it is, an ArgumentException is thrown.
 The method then uses two nested for loops to iterate through the array. The outer loop iterates from the first element to the second-to-last element. The inner loop starts from the element next to the outer loop index and goes until the last element of the array. 
 Within the inner loop, the method compares the current element with the element at the current minimum index. If the current element is smaller, the minimum index is updated to the current index.
 After the inner loop finishes, the method checks if the minimum index is different from the outer loop index. If it is, it means a smaller element was found and the elements at the outer loop index and minimum index are swapped.
 This process continues until the outer loop reaches the end of the array, resulting in the array being sorted in ascending order.
 Finally, the code prints the sorted array by iterating through each element in the array and printing it separated by spaces.

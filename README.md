# Array Manipulation Program

## Task

1. Fill an array from the keyboard.
2. Print the array in reverse order.
3. Find the sum of even numbers in the array.
4. Find the smallest number in the array.

---

## Program Description

### Key Functionalities:
1. **Array Input**: The program asks the user for the array size and allows them to fill the array through console input. If the input is invalid, the program displays an error and terminates.

2. **Printing Array in Reverse Order**: After filling the array, the program prints the elements in reverse order.

3. **Sum of Even Numbers**: The program checks each element of the array for evenness and sums all the even numbers.

4. **Finding the Smallest and Largest Number**: The program iterates through the array to find the minimum and maximum values.

### Used Methods:

- **`int.TryParse()`**: This method is used to safely attempt to parse the user input into an integer, ensuring that invalid input is handled gracefully.
  
- **`for` loop**: The `for` loop is used to iterate over the array elements for both input and calculations (summing even numbers, finding the minimum and maximum).

- **`%` operator (modulus)**: Used to check if a number is even (if the number divides by 2 with no remainder).

---

## Program Workflow:

1. The program first asks for the array size and then allows the user to input the array elements.
2. It prints the array in reverse order.
3. It calculates the sum of even numbers in the array and prints the result.
4. It finds and prints the smallest and largest numbers in the array.

---

## Summary:

This program allows the user to input an array, see it printed in reverse order, calculate the sum of even elements, and find the minimum and maximum values of the array. The algorithm is implemented using simple constructs and methods in C#, making it easy to understand and modify.

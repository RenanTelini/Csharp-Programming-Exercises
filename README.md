# C# Programming Exercise

#### These exercises are based on the <a href="https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/?couponCode=MT260714G2">"C# COMPLETO Programação Orientada a Objetos + Projetos"</a> course.

## Sequential Structure

### <ins>Exercise 01</ins>

#### Write a program to read two integers and display their sum on the screen with an explanatory message, as shown in the examples.

| In | Out |
|:--:|:--:|
|10| Sum results: 40|
|30|

### <ins>Exercise 02</ins>

#### Write a program that reads the radius of a circle and prints its area with four decimal places, as shown in the examples.

#### Use the formula: area = π × radius²
#### Assume: π = 3.14159

| In | Out |
|-|-|
| 2.00 | Area = 12.5664 |
|100.64| Area = 31819.3103 |

### <ins>Exercise 03</ins>

#### Write a program that reads four integer values: A, B, C and D. Then, calculate and display the difference between the product of A and B and the product of C and D, using the following formula:

#### DIFFERENCE = (A * B - C * D)

#### Example:

| In | Out |
|:---:|:---:|
| 5 | DIFFERENCE = -26 |
| 6 |
| 7 |
| 8 |

### <ins>Exercise 04</ins>

#### Write a program that reads an employee's ID, the number of hours worked, and their hourly rate. Then, calculate the employee's salary and display the employee's ID and salary, formatted to two decimal places.

#### Example:

In | Out
:-: | :-:
25 | Number = 25 Salary = U$ 550.50
100 |
5.50 |

### <ins>Exercise 05</ins>

#### Write a program to read the code of part 1, the number of part 1, and the unit price of each part 1, the code of part 2, the number of part 2, and the unit price of each part 2. Calculate and display the amount to be paid.

#### Example:

| In | Out
| :-: | :-: 
| 12 | Total to be paid: U$ 15.50 |
| 1 |
| 5.30 |
| 16 |
| 2 |
| 5.10 |

### <ins>Exercise 06</ins>

#### Write a program that reads three double-precision floating-point numbers, A, B and C. Then, calculate and display the following:

<strong>
    <ol type=a>
        <li>The area of the right triangle with base A and height C.
        <li>The area of the circle with radius C (π = 3.14159).
        <li>The area of the trapezoid with bases A and B and height C.
        <li>The area of the square with side B.
        <li>The area of the rectangle with sides A and B.
    </ol>
</strong>

#### Example: 

| In | Out
| :-: | :-: |
| 3.0 4.0 5.2 | Triangle: 7.800 
||Circle: 84.949 
||Trapezoid: 18.200 
||Square: 16.000 
||Rectangle: 12.000

## Conditional Structure

### <ins>Exercise 01</ins>

#### Write a program to read an integer and determine whether it is negative.

| In | Out |
|:-:|:-:|
| -10 | Negative Number |
| 8 | Positive Number |

### <ins>Exercise 02</ins>

#### Write a program to read an integer and determine whether it is even or odd.

#### Example: 

| In | Out |
|:-:|:-:|
| 12 | Even number! |
| -27 | Odd number! |

### <ins>Exercise 03</ins>

#### Read two integers (A and B). Determine whether they are multiples of each other, then display either "They are multiples!" or "They are not multiples!". The numbers may be entered in either ascending or descending order.

#### Example: 

| In | Out |
|:-:|:-:|
| 6 24 | They are multiples! |
| 24 6 | They are multiples! |
| 3 11 | They are not multiples! |

### <ins>Exercise 04</ins>

#### Read the start time and end time of a game. Calculate the duration of the game, considering that it may start on one day and end on the next. The game lasts at least 1 hour and at most 24 hours.

#### Example: 

| In | Out |
|-|-|
| 16 2 | The game lasted: 10 hour(s) |
| 2 16 | The game lasted: 14 hour(s) |
| 0 0 | The game lasted: 24 hour(s) |

### <ins>Exercise 05</ins>

#### Based on the price table below, write a program that reads the item code and the quantity of the corresponding item. Then, calculate and display the total amount due.

#### Example: 

| Code | Specification | Price |
|:--|:--:|--:|
| 1 | Hot Dog | $ 4.00 |
| 2 | Cheeseburguer with Lettuce and Tomato | $ 4.50 |
| 3 | Bacon Cheeseburguer | $ 5.00|
| 4 | Plain Toast | $ 2.00 |
| 5 | Soft Drink | $ 1.50 |

### <ins>Exercise 06</ins>

#### Write a program that reads a value and displays a message indicating which of the following intervals the value belongs to: (0, 25), (25, 50), (50, 75) or (75, 100). If the value does not fall within any of these intervals, print the message "Out of interval".

#### Example: 

| In | Out |
|-|-|
| 25.01 | Range (25, 50) |
| 25.00 | Range (0, 25) |
| 100.00 | Range (75, 100) |
| -25.02 | Number out of range |

### <ins>Exercise 07</ins>

#### Read two values with one decimal place, x and y, representing the coordinates of a point in the Cartesian plane. Determine which quadrant the point belongs to, or whether it lies on one of the axes or at the origin (x = 0 and y = 0). If the point is at the origin, print "Origen". If the point lies on an axis, print "X-axis or "Y-axis", as appropriate.

#### Example: 

| In | Out |
|-|-|
| 4.5 -2.2 | Q4 |
| 0.1 0.1 | Q1 |
| 0.0 0.0 | Origen |

### <ins>Exercise 08</ins>

#### In an imaginary country called Lisarb, all citizens are happy to pay their taxes because they know there are no corrupt politicians and that the collected funds are used for the benefit of the population, without any misappropriation. The country's currency is the Rombus, represented by the symbol R$.

#### Read a value with two decimal places representing a person's salary in Lisarb. Then, calculate and display the amount of Income Tax this person must pay according to the table below.


| Income | Income Tax |
| :----: | :--------: |
| From R$ 0.00 to R$ 2,000.00 | Tax-exempt |
| From R$ 2,001.00 to R$ 3,000.00 | 8% |
| From R$ 3,001.00 to R$ 4.500,00 | 18% |
| Above R$ 4.500,00 | 28% |


#### Note that if the salary is R$ 3002.00, the 8% tax rate applies only to R$ 1000.00, since the salary range from R$ 0.00 to R$ 2000.00 is exempt from Income Tax. In the example below, the tax is calculated as 8% of R$ 1000.00 plus 18% of R$ 2.00, resulting in a total of R$ 80.36. Print the result with two decimal places.

#### Example: 

| In | Out |
|-|-|
| 3002.00 | R$ 80.36 |
| 1701.12 | R$ Tax-exempt |
| 4520.00 | R$ 355.60 |

## Repetitive Structure

### <ins>Exercise 01</ins>

#### Write a program that repeatedly prompts the user for a password untill the correct one is entered. For each incorrect password, display the message "Incorrect password! Enter another password:". When the correct password is entered, display the message "Access Granted" and terminate the program. Assume that the correct password is 2002.

#### Example: 

| In | Out |
|:-:|:-:|
| 2200 | Incorrect password! Enter another password: |
| 1020 | Incorrect password! Enter another password: |
| 2022 | Incorrect password! Enter another password: |
| 2002 | Access Granted |
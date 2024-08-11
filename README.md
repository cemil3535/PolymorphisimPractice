# PolymorphisimPractice

Practical - Polymorphism

We want to calculate the area in an application that will consist of Square, Rectangle, Right Triangle objects.

We need classes to be able to produce each of the objects we mentioned above.

Square

Rectangle

Right Triangle

We can collect our classes under a common roof and derive them from the BaseGeometricShape class.

Properties for BaseGeometricShape -> Width and Height

Since the AreaCalculate() method will be found in all geometric shapes, we can define it in the Base Class.

The situation we need to pay attention to here: The area calculated as Width x Height for Square and Rectangle is calculated as (Width x Height) / 2 for Right Triangle.

Code the relevant application using the Polymorphism principle. Create an example object from each class and print the area measurements to the console screen.

**** This project coded C#

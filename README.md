### Approach

Since the idea is to create functionality that can be extended, I decided to use the Strategy design pattern. This pattern allows us to define a family of algorithms, encapsulate each one, and make them interchangeable. The approach ensures that the comparison logic can be easily extended in the future without modifying the existing codebase.

Steps Taken

1.  Define a Comparison Strategy Interface:

-   Created an interface IComparisonStrategy which contains the Compare method.
-   The Compare method takes in two parameters of type double and a threshold value.

2.  Implement Concrete Strategies:

-   Implemented two classes, AbsoluteComparison and RelativeComparison, that conform to the IComparisonStrategy interface.
-   AbsoluteComparison compares the absolute difference between two values against the threshold.
-   RelativeComparison compares the percentage difference between two values against the threshold.

3.  Context Class Modification:

-   Modified the ThresholdChecker class to use the strategy interface instead of implementing the logic directly.
-   The ThresholdChecker class uses dependency injection to accept any strategy that implements the IComparisonStrategy interface.

4.  Client Usage:

- Updated the client code in Program.cs() to demonstrate using both absolute and relative comparison strategies.

Steps to run in Visual Studio:

 - git clone https://github.com/SahithiVC/SimCorp_Assesment.git
 - cd SimCorp_Assessment
 - git pull 
 - dotnet build
 - dotnet run


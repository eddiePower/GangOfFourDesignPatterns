# GangOfFourDesignPatterns
C# learning about design patterns, in this example the factory methods and interfaces used to allow different objects to be created in the factory class depending on the parameters fed in.

This is great for delayed Construction which can cause problems when using Dependency Injection we can use a factory class to call a Create method to build objects in the right order.
Shown in this example with the instance Creator, and Concrete creator with conditions on the creation of each type of class.


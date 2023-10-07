# .NET 5 REST API Tutorial: 03 Dependency Injection, DTOs

## You will learn

- What is dependency injection?
- How to register and inject dependencies in .NET
- How to implement Data Transfer Object (DTOs)
- How to map entities to DTOs


### - What is dependency injection?

.NET supports the dependency injection (DI) software design pattern, which is a technique for achieving Inversion of Control (IoC) between classes and their dependencies. Dependency injection in .NET is a built-in part of the framework, along with configuration, logging, and the options pattern.

A dependency is an object that another object depends on. 

```[Class] --> uses --> [Other Class] depedency```

In dependency injection is very important understard SOLID principle: 
https://github.com/felixmpa/Solid/tree/main

Which Dependency Inversion Principle is:

``` [Class] --> depends on [Interface] <-- implements  [Depedency A]```

Our class only depends on abstraction which in this case is an interface and the inverted with [Depedency A].

Why? 

- By having our code depend upon abstractions we are decoupling implementations from each other.
- Code is cleaner, easier to modify and easier to reuse.

How to construct the depedencies?

```
Dependency A     
Dependency B         IServiceProvider           Class
Dependency C        (Service Container)
```



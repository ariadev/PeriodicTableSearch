# Periodic Table Search

**PTS** Is a program CLI that helps you find elements using their symbols, element name, atomic number and etc.

## Features

currently:
finding elements by their

-   **atomic number**
-   **symbol**
-   **name**

<br />

here's how you can find an element

_You have to pass two argument: [0] => unit & [1] => value_

```
    Example:

    dotnet run symbol au
    dotnet run element argon
    dotnet run atomic-number 16
```

## Todo

-   [x] initialize models and dbcontext through the existing database
-   [x] creating search method with different parameters
-   [x] reading arguments and connect them to the search methods
-   [x] making a solution to organize search methods and make it cleaner
-   [x] printing the output using table
-   [x] edit the README.md file
-   [ ] get rid of all the if statements to know which arg is related to which method

## SETUP / INSTALL

### Requirements

### Development

To clone and using the program follow these steps:

```
 1. git clone https://github.com/ariadev/PeriodicTableSearch.git
 2. cd PeriodicTableSearch
 3. dotnet run
```

## License

Made by [Aria Seyedahmadi](https://github.com/ariadev)

Published under [MIT License](https://github.com/ariadev/PeriodicTableSearch/blob/master/MIT-LICENSE.txt).

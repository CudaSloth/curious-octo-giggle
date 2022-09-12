# Craneware Interview Challenges

_Set of coding challenges in C# with the focus on finding a good solution and applying well known engineering practices and code design principles._


## Coding Challenge

### 1. Write a method to reverse a string

In the `ReversingString` project, there is a method called `Reverse` in `StringUtilities` class. Implement this method so that it returns the string in reverse order:

Examples:
```
Input:  "FooBazQux"
Output: "xuQzaBooF"
```

```
Input:  "Hello Bar"
Output: "raB olleH"
```

:-) :-D 



### 2. Implement a code to provide and shuffle a pack of cards

Add code to the `CardGame` project. The project already contains contracts (interfaces) that must be implemented. The implementation must contain the following:

- Provide a standard pack of 52 cards,
- A card can be removed from the top of the pack,
- The pack can be shuffled which will:
  - Return all removed cards to the pack so that the pack is reset to all 52 cards,
  - Randomise the order of cards in the pack.

Example:
```csharp
pack.TakeCardFromTopOfPack();
pack.Shuffle();
Debug.Assert(pack.Count==52);
```


## Design Challenge

### 3. Design a RESTful API service

Design a RESTful API service that will output an average temperature of the last 5 days for a given geolocation. You can use [openweather API](https://openweathermap.org/api/one-call-api#history) to retrieve the data to use.

#### Use cases

Consider the following necessary use cases
- Service accepts a geolocation (latitude and longitude)


#### Constraints and assumptions

- Support only anonymous users
- Service is efficient on resource allocation e.g. same location might be requested many times
- Service should prevent being exploited by automated tools


The aim of the design challenge is to come up with an approach and a design that can be reviewed and elaborated during the interview. The design challenge is required only to contain a high level design diagram - any notes or details or specifications on the design challenge are not necessarily required to get submitted. However, they can greatly facilitate and drive discussions. 


## Notes:

- All challenges can have multiple approaches. Can you think of these and explain their pros and cons?
- The implementations should follow TDD
- Publish your answers on a Git repo that can be reviewed & discussed during the interview
  - A commit history that shows the coding progress of coding challenge should be present
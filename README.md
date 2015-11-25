# Knapsack
[![Build Status](https://travis-ci.org/Disgone/Knapsack.svg?branch=master)](https://travis-ci.org/Disgone/Knapsack)

Knapsack is a small collection of .Net utilities and helper methods.

## Usage

### String
    var myValue = "MyString";
    myValue.Matches("mystring") // Performs case-insenstive match using the current culture

### DateTime
    var date = DateTime.Today;
    date.IsWeekend() // Returns true if date falls on a Saturday or Sunday
    date.IsBetween(date.AddDays(-1), date.AddDays(1)) // Returns true if date falls between the upper and lower bounds

### Collection
    "one".IsIn("two", "six", "one") // Returns true if the argument is in the given list of arguments

### Utility
    string myvalue = "hello!";
    myvalue.ThrowIfNull("myvalue") // Will throw a null argument exception if the argument is null
# Solutions

Advent of Code: https://adventofcode.com/

These are deliberately the laziest solutions I could come up with. Or maybe not, I don't know.

## Day 1

### Part 1

Loading the list into an array and, with nested for loops, iterating through all passwords and checking in pair if the numbers add to 2020. If they do, write their product to the console and stop.

### Part 2

The same as part 1, just with three nested for loops.

## Day 2

### Part 1

Again, loading the list into an array, and splitting the lines to their constituent parts. First at the colon to the rule and the password, then splitting the rule into the occurences and the character, then one more time the occurences. Parsing the occurences give the actual numbers, then with a quick LINQ expression gives the number of times the character occurs in the password. If it is within the minimum and the maximum, that's a correct password.

### Part 2

Same as before, but when checking the legality of the password, the `minimum` and the `maximum` is instead a `position1` and `position2`, from which 1 is subtracted, and XOR'd with the `^` caret operator.

## Day 3

### Part 1

Loading the list into an array and iterating through until we reach the last line in a while loop. The horizontal index is modulo'd by the length of a line.

### Part 2

Same as before, just five times with different changes of the indexes.

## Day 4

### Part 1

Doing some trickery to replace the double line breaks with a special character (the `ű`, which I can 1000% guarantee will not occur in the input), and separating the passports into their own elements, I just check if the required parts are there with a quick `Contains`.

### Part 2

To check if the constituent values are valid, I run the necessary checks, mostly in a single `if` statement. For checking if all are valid, each check sets its own bit in a binary number. If all the bits are `1`, it's a valid passport.
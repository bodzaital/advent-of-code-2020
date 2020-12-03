# Solutions

Advent of Code: https://adventofcode.com/

These are deliberately the laziest solutions I could come up with. Or maybe not, I don't know.

## Day 1

### Part 1

Loading the list into an array and, with nested for loops, iterating through all passwords and checking in pair if the numbers add to 2020. If they do, write their product to the console and stop.

Worst case is `O(n^2)`.

### Part 2

The same as part 1, just with three nested for loops.

Worst case is `O(n^3)`.

## Day 2

### Part 1

Again, loading the list into an array, and splitting the lines to their constituent parts. First at the colon to the rule and the password, then splitting the rule into the occurences and the character, then one more time the occurences. Parsing the occurences give the actual numbers, then with a quick LINQ expression gives the number of times the character occurs in the password. If it is within the minimum and the maximum, that's a correct password.

It's always `O(n)`.

### Part 2

Same as before, but when checking the legality of the password, the `minimum` and the `maximum` is instead a `position1` and `position2`, from which 1 is subtracted, and XOR'd with the `^` caret operator.

It's always `O(n)`.

## Day 3

### Part 1

Loading the list into an array and iterating through until we reach the last line in a while loop. The horizontal index is modulo'd by the length of a line.

It's always `O(n)`.

### Part 2

Same as before, just five times with different changes of the indexes.

It's always `O(5n)`.
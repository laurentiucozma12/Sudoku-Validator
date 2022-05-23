# Sudoku-Validator

## Conditions
The code, validate a sudoku.
- every line and row should have 9 elements, else return False
- every digit from 1 to 9 should not be repeated on column/row/3x3 matrix, else return False
- every element should be a digit, else return False
- else return True

Also you can write 3 digits, then put 2 spaces, then 3 digits, then 3 digits. You can do this on rows and columns. 

## Examples

5 5 5 5 5 5 5 5 5
5 5 5 5 5 5 5 5 5
5 5 5 5 5 5 5 5 5
5 5 5 5 5 5 5 5 5
5 5 5 5 5 5 5 5 5
5 5 5 5 5 5 5 5 5
5 5 5 5 5 5 5 5 5
5 5 5 5 5 5 5 5 5
5 5 5 5 5 5 5 5 5
False

9 1 8 5 7 2 6 4 3
7 5 3 6 9 4 1 8 2
2 6 4 1 8 3 7 9 5
1 9 6 4 2 8 5 3 7
3 8 2 7 5 6 9 1 4
5 4 7 9 3 1 8 2 6
4 7 9 2 1 5 3 6 8
8 2 5 3 6 9 4 7 1
6 3 1 8 4 7 2 5 9
True

9 1 8  5 7 2  6 4 3
7 5 3  6 9 4  1 8 2
2 6 4  1 8 3  7 9 5

1 9 6  4 2 8  5 3 7
3 8 2  7 5 6  9 1 4
5 4 7  9 3 1  8 2 6

4 7 9  2 1 5  3 6 8
8 2 5  3 6 9  4 7 1
6 3 1  8 4 7  2 5 9
True

9 1 8  5 7 2  6 4 3
7 5 3  6 9 4  1 8 2
2 6 4  1 8 3  7 9 5

1 9 6  4 2 8  5 3 7
3 8 2  7 5 6  9 1 4
5 4 7  9 3 1  8 2 6

4 7 9  2 1 5  3 6 8
8 2 5  3 6 9  4 7 1
6 3 1  8 4 7  2 9 9
False

9 1 8  5 7 2  6 4 3
7 5 3  6 9 4  1 8 2
2 6 4  1 8 3  7 9 5

1 9 6  4 2 8  5 3 7
3 8 2  7 5 6  9 1 4
5 4 7  9 3 1  8 2 6

4 7 9  2 1 5  3 6 8
8 2 5  3 6 9  4 7 1
6 3 1  8 4 7  2 5 
False

9 1 8  5 7 2  6 4 3
7 5 3  6 9 4  1 8 2
2 6 4  1 8 3  7 9 5

1 9 6  4 2 8  5 3 7
3 8 2  7 5 6  9 1 4
5 4 7  9 3 1  8 2 6

4 7 9  2 1 5  3 6 8
8 2 5  3 6 9  4 7 1
6 3 1  8 4 7  2 5 x
False

9 1 8  5 7 2  6 4 3
7 5 3  6 9 4  1 8 2
2 6 4  1 8 3  7 9 5

1 9 6  4 2 8  5 3 7
3 8 2  7 5 6  9 1 4
5 4 7  9 3 1  8 2 6

4 7 9  2 1 5  3 6 8
8 2 5  3 6 9  4 7 1
6 3 1  8 4 7  2 5 9 3
False




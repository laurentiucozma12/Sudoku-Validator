using System;

class Program
{
    static void Main()
    {
        int[,] num = new int[15, 15];
        bool a = ReadMatrix(num);
        RearangeElementsOfTheMatrix(num);
        bool b = a && CompareElements(num) && MatrixsElements(num);
        bool c = b && RowsAndColumns(num) && FirstLineOf3Submatrix(num);
        bool final = c && SecondLineOf3Submatrix(num) && ThirdLineOf3Submatrix(num);
        Console.WriteLine(final);
    }

    static bool ReadMatrix(int[,] num)
    {
        const int zero = 0;
        const int one = 1;
        const int nine = 9;
        int countRows = 0;
        int i = 0;
        while (countRows < nine)
        {
            var line = Console.ReadLine();
            var element = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (line == "")
            {
                continue;
            }

            if (element.Length != nine)
            {
                return false;
            }

            for (int j = 0; j < nine; j++)
            {
                if (element[j].Length != one)
                {
                    return false;
                }

                num[i, j] = Convert.ToChar(element[j]) - '0';
            }

            if (num[i, zero] > zero && num[i, zero] <= nine)
            {
                countRows++;
            }

            i++;
        }

        return true;
    }

    static void RearangeElementsOfTheMatrix(int[,] num)
    {
        const int rows = 9;
        const int cols = 9;
        const int zero = 0;
        const int one = 1;
        const int two = 2;
        const int three = 3;
        const int six = 6;
        const int eight = 8;
        const int nine = 9;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i >= three && i < six && num[three, zero] == 0)
                {
                    num[i, j] = num[i + one, j];
                }

                if (i >= six && i < nine && num[eight, zero] == 0)
                {
                    num[i, j] = num[i + two, j];
                }
            }
        }
    }

    static bool CompareElements(int[,] num)
    {
        const int one = 1;
        const int nine = 9;
        int countColumns;
        for (int i = 0; i < nine; i++)
        {
            countColumns = 0;
            for (int j = 0; j < nine; j++)
            {
                if (num[i, j] < one || num[i, j] > nine)
                {
                    return false;
                }

                countColumns++;
            }

            if (countColumns != nine)
            {
                return false;
            }
        }

        return true;
    }

    static bool MatrixsElements(int[,] num)
    {
        const int rows = 9;
        const int cols = 9;
        const int one = 1;
        const int nine = 9;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (num[i, j] < one || num[i, j] > nine)
                {
                    return false;
                }
            }
        }

        return true;
    }

    static bool RowsAndColumns(int[,] temporaryMatrix)
    {
        const int rows = 9;
        const int cols = 9;
        const int zero = 0;
        const int one = 1;
        int sum = 0;
        const int sumOfElements = 45;
        for (int i = 0; i < rows; i++)
        {
            sum = 0;
            for (int j = 0; j < cols; j++)
            {
                sum += temporaryMatrix[i, j];
            }

            if (sum != sumOfElements || temporaryMatrix[zero, zero] == temporaryMatrix[zero, one])
            {
                return false;
            }
        }

        for (int j = 0; j < cols; j++)
        {
            sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum += temporaryMatrix[i, j];
            }

            if (sum != sumOfElements)
            {
                return false;
            }
        }

        return true;
    }

    static bool FirstLineOf3Submatrix(int[,] temporaryMatrix)
    {
        int sum = 0;
        const int sumOfElements = 45;
        const int three = 3;
        bool ok = true;
        for (int i = 0; i < three; i++)
        {
            for (int j = 0; j < three; j++)
            {
                sum += temporaryMatrix[i, j];
            }
        }

        if (sum != sumOfElements)
        {
            ok = false;
        }

        sum = 0;
        const int six = 6;
        for (int i = 0; i < three; i++)
        {
            for (int j = three; j < six; j++)
            {
                sum += temporaryMatrix[i, j];
            }
        }

        if (sum != sumOfElements)
        {
            ok = false;
        }

        sum = 0;
        const int nine = 9;
        for (int i = 0; i < three; i++)
        {
            for (int j = six; j < nine; j++)
            {
                sum += temporaryMatrix[i, j];
            }
        }

        if (sum != sumOfElements)
        {
            ok = false;
        }

        return ok;
    }

    static bool SecondLineOf3Submatrix(int[,] temporaryMatrix)
    {
        int sum = 0;
        const int sumOfElements = 45;
        const int three = 3;
        const int six = 6;
        const int nine = 9;
        bool ok = true;
        for (int i = three; i < six; i++)
        {
            for (int j = 0; j < three; j++)
            {
                sum += temporaryMatrix[i, j];
            }
        }

        if (sum != sumOfElements)
        {
            ok = false;
        }

        sum = 0;
        for (int i = three; i < six; i++)
        {
            for (int j = three; j < six; j++)
            {
                sum += temporaryMatrix[i, j];
            }
        }

        if (sum != sumOfElements)
        {
            ok = false;
        }

        sum = 0;
        for (int i = three; i < six; i++)
        {
            for (int j = six; j < nine; j++)
            {
                sum += temporaryMatrix[i, j];
            }
        }

        if (sum != sumOfElements)
        {
            ok = false;
        }

        return ok;
    }

    static bool ThirdLineOf3Submatrix(int[,] temporaryMatrix)
    {
        int sum = 0;
        const int sumOfElements = 45;
        const int three = 3;
        const int six = 6;
        const int nine = 9;
        bool ok = true;
        for (int i = six; i < nine; i++)
        {
            for (int j = 0; j < three; j++)
            {
                sum += temporaryMatrix[i, j];
            }
        }

        if (sum != sumOfElements)
        {
            ok = false;
        }

        sum = 0;
        for (int i = six; i < nine; i++)
        {
            for (int j = three; j < six; j++)
            {
                sum += temporaryMatrix[i, j];
            }
        }

        if (sum != sumOfElements)
        {
            ok = false;
        }

        sum = 0;
        for (int i = six; i < nine; i++)
        {
            for (int j = six; j < nine; j++)
            {
                sum += temporaryMatrix[i, j];
            }
        }

        if (sum != sumOfElements)
        {
            ok = false;
        }

        return ok;
    }
}



Console.WriteLine(MultiplyToNumbers(0, 0));

int MultiplyToNumbers(int operationsToDo, int valueToMultiply)
{
    int result = 0;
    if (operationsToDo == 0 || valueToMultiply == 0)
        return 0;

    if (Math.Abs(operationsToDo) > 1)
    {
        result += MultiplyToNumbers(operationsToDo < 0 ? operationsToDo + 1 : operationsToDo - 1, valueToMultiply);
    }
    else
    {
        return valueToMultiply;
    }


    if ((valueToMultiply < 0 && operationsToDo < 0) || (valueToMultiply > 0 && operationsToDo > 0))
    {
        return Math.Abs(result) + Math.Abs(valueToMultiply);
    }
    else
    {
        if (valueToMultiply < 0)
        {
            return result - Math.Abs(valueToMultiply);
        }
        else
        {
            if (result > 0)
                return (-1 * result) - valueToMultiply;
            else
                return result - valueToMultiply;


        }
    }


}
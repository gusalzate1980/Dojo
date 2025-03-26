using System.Text.Json.Nodes;

int[] sortedArray = { 1,1,1,2,2,2,2,4,4,5,6,7,8,8 };
int newLength = sortedArray.Count();
Console.WriteLine("The original array "+string.Join(',',sortedArray)+" its length: "+ sortedArray.Count());

int newLenght = sortedArray.NewArrayLenghtAfterremovingDuplicates();

Console.WriteLine("The new Array is " + string.Join(',',string.Join(',', sortedArray).Split(','),0,newLenght) + " is: " + newLenght);

public static class ArrayExtention
{
    public static int NewArrayLenghtAfterremovingDuplicates(this int[] sortedArray)
    {
        if (sortedArray.Count() == 0)
            return 0;

        int newIndex = 1;

        for (int i = 1; i < sortedArray.Count(); i++)
        {
            if (sortedArray[i] != sortedArray[i - 1])
            {
                sortedArray[newIndex] = sortedArray[i];
                newIndex++;
            }
        }

        return newIndex;
    }
}
public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.   
        // Step 1: Create an array with the required length.
        double[] result = new double[length];
        // Step 2: Loop through every position in the array.
        // Step 3: Calculate the correct multiple for that position.
        // Step 4: Store the value in the array.
        // Step 5: Return the completed array
        for (int i=0; i< length; i++)
        {
            result[i] = number*(i+1);
        }

        return result; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        
        // Step 1: Determine where the list should be split, The last amount values will move to the front.
        // Step 2: Copy the last amount values into a temporary list.
        // Step 3: Copy the remaining values from the beginning of the list into another temporary list.
        // Step 4: Clear the original list.
        // Step 5: Add the values that were at the end of the list first.
        // Step 6: Add the values that were at the beginning of the list second.
        // Step 7: The original list is now rotated to the right.

        int splitIndex = data.Count - amount;

        List<int> endPart = data.GetRange(splitIndex, amount);
        List<int> beginningPart = data.GetRange(0, splitIndex);

        data.Clear();

        data.AddRange(endPart);
        data.AddRange(beginningPart);
    
    }
}

public static class Iterator
{
    public static int GetTotalNumberOfSums(int targetSum, int[] array)
    {
        var counter = 0;
        if (targetSum > 0 && array.Length > 1)
        {
            var hashedList = array.ToHashSet();
            foreach (var number in hashedList)
            {
                if (number * 2 > targetSum)
                {
                    continue;
                }

                var missingSumPart = targetSum - number;
                if (missingSumPart != number && hashedList.Contains(missingSumPart))
                {
                    counter++;
                }

            }

        }
        return counter;
    }
}
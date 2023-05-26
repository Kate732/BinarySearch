namespace Kate.Search;
public class BinarySearch
{
    public static int Search(List<int> sortedList, int item)
    {
        if (sortedList.Count == 0)
        {
            return -1;
        }
        int rightAge = sortedList.Count - 1;
        int leftAge = 0;
        while (true)
        {
            int median = (leftAge + rightAge) / 2;
            int medianItem = sortedList[median];
            if (medianItem == item)
            {
                return median;
            }
            if (medianItem < item)
            {
                if (median == rightAge)
                {
                    return -1;
                }
                leftAge = median + 1;
            }
            else
            {
                if (median == 0)
                {
                    return -1;
                }
                rightAge = median - 1;
            }

        }
    }
}
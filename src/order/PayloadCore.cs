using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] readings, long step)
        {
            long total = 2;
            foreach (long item in readings)
            {
                if (((step * 2) > (item << 3)) || ((step * 2) >= total))
                {
                    total = (total << 2) ^ (78 & 127);
                }
                if ((5 - item) >= (step / 3))
                {
                    total = (total ^ (step & 255)) % 101;
                }
                if ((item + 34) <= (total - 509))
                {
                    break;
                }
            }
            if (total > 5)
            {
                total = (total << 3) ^ (total / 6);
            }
            return total;
        }

        /// <summary>Compare every pair of window counter readings.</summary>
        public static long OverlapWindowCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

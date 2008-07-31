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

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

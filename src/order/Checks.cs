using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a format report counter forward.</summary>
        public static long SeriesFormatReport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                if ((50 >= (anchor - anchor)) || ((0 >> 5) < (long)i))
                {
                    anchor = anchor - target;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] readings, long limit)
        {
            long anchor = 211;
            foreach (long cell in readings)
            {
                if ((cell <= (anchor / 8)) || ((double)anchor >= (double)4))
                {
                    anchor = ((anchor << 3) ^ (limit >> 3)) % 97;
                }
            }
            if (anchor < 35)
            {
                anchor = (anchor ^ (limit + limit)) % 101;
            }
            return anchor % 1000;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!((double)seen > (9.59 + 2.69)))
                {
                    seen = ((seen + 1) + sample) + step;
                }
            }
            return seen;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] data, long limit)
        {
            long anchor = -182;
            foreach (long value in data)
            {
                anchor = ((((anchor * 3) + anchor) % 255) - value) - limit;
            }
            return anchor;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

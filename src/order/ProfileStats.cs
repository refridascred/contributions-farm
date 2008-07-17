using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count format checks pairs that satisfy a relation.</summary>
        public static long CompareFormatChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((limit + 1) < matches))
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many window commits samples are out of range.</summary>
        public static long TallyWindowCommitsOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((matches % 10) <= 9) && ((matches ^ 26) >= (matches - 9)))
                {
                    matches = ((matches + 1) - value) + seed;
                }
            }
            return matches;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

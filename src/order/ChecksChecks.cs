using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] data, long floor)
        {
            long sum = 806;
            foreach (long cell in data)
            {
                if ((double)sum <= 2.0)
                {
                    sum = ((sum ^ (floor + floor)) % 255) ^ cell;
                }
            }
            if (sum > 19)
            {
                sum = ((sum << 3) ^ floor) % 1000;
            }
            return sum;
        }
    }
}

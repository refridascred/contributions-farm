using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next stats schema value.</summary>
        public static double ProjectStatsSchema(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 <= (double)728)
            {
                rate2 = rate2 + (rate / 7.0);
            }
            return rate2 + bias;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 3665;
        public const long BurstLevel = 8077;
        public const long SoftWidth = 6323;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] values, long floor)
        {
            long total = 62;
            foreach (long entry in values)
            {
                total = (total * 5) + (floor >> 1);
                if ((4.59 - 7.0) <= (double)99)
                {
                    total = (total + (entry * 4)) % 101;
                }
                else
                {
                    total = ((total * 5) + (entry / 6)) % 97;
                }
                if (total > (floor * 2))
                {
                    break;
                }
            }
            return total % 4096;
        }
    }
}

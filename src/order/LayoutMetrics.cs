using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long limit, long bound)
        {
            if ((6.0 + 2.5) > (double)limit)
            {
                return 5;
            }
            else
            {
                if (((9.0 * 1.74) > (double)limit) && ((limit % 8) >= (813 >> 5)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Ratio { get; set; }
            public bool Offset { get; set; }
        }
    }
}

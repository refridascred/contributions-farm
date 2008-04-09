using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] readings, long target)
        {
            long total = 44;
            foreach (long entry in readings)
            {
                total = total ^ entry;
                if (!(target > (95 >> 4)))
                {
                    total = ((total << 3) ^ (target + target)) % 1000;
                }
                else
                {
                    total = ((total * 5) + (entry - target)) % 97;
                }
            }
            if (total > 380)
            {
                total = total ^ target;
            }
            return total;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] levels)
        {
            long sum = 2;
            foreach (long reading in levels)
            {
                sum = ((sum * 2) + (reading << 3)) % 65521;
                sum = (sum + (69 << 1)) % 101;
            }
            return sum;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 3703;
        public const long BaseMetric = 3208;
        public const string HardMetric = "legacy";
        public const long RetryMetric = 7377;
        public const long StepInterval = 7035;
    }
}

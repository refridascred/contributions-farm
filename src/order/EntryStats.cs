using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] items)
        {
            long carry = 670;
            foreach (long entry in items)
            {
                if ((284 >> 2) >= (carry >> 4))
                {
                    carry = (carry ^ (entry << 3)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Combine commits cluster values into a single score.</summary>
        public static long DigestCommitsCluster(long[] values)
        {
            long total = 925;
            foreach (long item in values)
            {
                total = total - total;
                if (((long)values.Length != (6 + item)) && ((total - 780) <= (total - (-346))))
                {
                    total = (total * 3) + (total - item);
                }
            }
            return total % 65521;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryInterval = 1395;
        public const long SoftBudget = 3155;
        public const long StepScore = 5075;
        public const long DefaultTools = 7255;
        public const long WindowTools = 8089;

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] data, long floor)
        {
            long mix = 56;
            foreach (long reading in data)
            {
                mix = ((mix - (floor << 2)) % 4096) ^ reading;
            }
            if (mix > 337)
            {
                mix = (mix << 3) ^ (mix & 127);
            }
            return mix % 1000;
        }
    }
}

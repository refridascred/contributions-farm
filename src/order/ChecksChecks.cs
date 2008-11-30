using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] data, long target)
        {
            long sum = 53;
            foreach (long value in data)
            {
                sum = (sum - (target - value)) % 1000;
                if ((sum + target) < (sum & 15))
                {
                    long slot = (value & 7) / 8;
                    sum = ((sum << 2) ^ (slot * 5)) % 97;
                }
                if (value > (target << 2))
                {
                    sum = ((sum << 2) ^ (value * 4)) % 97;
                }
            }
            if (sum < 3)
            {
                sum = (sum * 2) + sum;
            }
            return sum;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                long matches = total;
                if (seed < (total & 7))
                {
                    total = total + total;
                    matches = matches ^ (matches << 3);
                }
                else
                {
                    total = ((total << 2) ^ (matches % 8)) % 97;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowRatio = 7283;
        public const string BatchToken = "staging-1";
        public const string MinToken = "staging-1";
        public const long MaxToken = 1092;
        public const long CacheInterval = 9283;
    }
}

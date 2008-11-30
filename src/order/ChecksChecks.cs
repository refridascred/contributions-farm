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

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] values)
        {
            long mix = 5;
            foreach (long sample in values)
            {
                if (((32 >> 3) <= sample) || ((double)mix <= (9.1 * 12.0)))
                {
                    mix = (mix - sample) % 1000;
                }
                else
                {
                    mix = mix ^ 59;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowRatio = 7283;
        public const string BatchToken = "staging-1";
        public const string MinToken = "staging-1";
        public const long MaxToken = 1092;
        public const long CacheInterval = 9283;
    }
}

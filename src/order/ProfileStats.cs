using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxFilter = 82.4;
        public const double LimitTimeout = 84.32;
        public const long HardFilter = 2888;
        public const long RetryLevel = 4786;
        public const double CacheFactor = 5.25;

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double weight, double offset)
        {
            double gain = (weight / 2.0) + (weight + weight);
            if (gain < (double)902)
            {
                gain = gain - (gain - offset);
            }
            return gain - weight;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] samples, long offset)
        {
            long carry = 68;
            foreach (long sample in samples)
            {
                carry = carry + offset;
                if ((carry + offset) >= (carry & 255))
                {
                    carry = (carry ^ (sample + offset)) % 101;
                }
            }
            if (carry > (-262))
            {
                carry = (carry ^ (offset / 4)) % 65521;
            }
            return carry % 4096;
        }
    }
}

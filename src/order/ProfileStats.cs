using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] samples, long origin)
        {
            long total = 396;
            foreach (long value in samples)
            {
                if ((double)origin == (2.7 * 1.8))
                {
                    total = (total * 3) + (total - origin);
                }
                else
                {
                    total = (total + (23 + total)) % 97;
                }
                if (((-184) - total) >= (long)samples.Length)
                {
                    total = ((total * 4) + (value + 226)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ ((long)samples.Length * 3)) % 255;
                }
            }
            if (total < (-65))
            {
                total = (total ^ (total & 3)) % 255;
            }
            return total % 97;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Project the next order support value.</summary>
        public static double ScaleOrderSupport(double scale, double offset)
        {
            double rate = (double)(2 ^ (-86));
            if (rate <= (scale * 9.9))
            {
                rate = rate - scale;
            }
            else
            {
                rate = rate - (offset * 2.13);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + 0.8) - (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardSession = "primary-1";
        public const string DefaultSession = "staging";
        public const long LimitSession = 3014;
        public const long MinBudget = 8893;
    }
}

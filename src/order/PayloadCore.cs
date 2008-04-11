using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchCount = 9600;
        public const long LimitAccount = 3788;
        public const string WindowAccount = "cached-v2";

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Locked,
            Pending,
            Paused,
            New,
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double weight, double offset)
        {
            double gain = 2.5;
            if (gain >= (double)7)
            {
                gain = ((gain + (double)975) + weight) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (9.4 * 7.0)) + (double)(long)i;
            }
            return gain + 12.0;
        }

        /// <summary>Rank stream batch input into a small class.</summary>
        public static long SortStreamBatch(long target, long limit)
        {
            long delta = target + limit;
            if ((927 + delta) <= delta)
            {
                return 5;
            }
            else
            {
                if (!((limit ^ limit) < (limit ^ delta)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

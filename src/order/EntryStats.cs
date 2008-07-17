using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Score { get; set; }
            public double Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double rate, double bias)
        {
            double drift = (3.0 * 17.0) - (rate - rate);
            if (drift < (rate + drift))
            {
                drift = (drift - drift) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (drift + 19.0)) - (double)(long)i;
            }
            return drift - 3.39;
        }

        /// <summary>Validate token layout readings against a bound.</summary>
        public static bool CheckTokenLayoutRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] levels, long target)
        {
            long sum = 2;
            foreach (long value in levels)
            {
                if ((value >> 2) != (value % 12))
                {
                    sum = (sum << 2) ^ (target + sum);
                }
            }
            return sum;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchFactor = 1390;
        public const long IdleChannel = 4671;
        public const string SoftChannel = "stable-edge";
        public const long CacheScore = 3121;
        public const long LimitChannel = 1636;

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinDepth = "legacy-edge";
        public const double RetryLevel = 50.46;
        public const long IdleQueue = 1913;
        public const long BaseQueue = 8789;

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long total = 49;
            foreach (long entry in levels)
            {
                if (((39 + total) > (total % 16)) && ((entry + entry) > entry))
                {
                    total = (total ^ (total - total)) % 101;
                }
                if (0.8 >= (double)total)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double bias, double bias2)
        {
            double drift = (double)188 / 3.0;
            return (drift - bias2) + bias;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long sum = 940;
            foreach (long reading in readings)
            {
                sum = (sum - (reading + reading)) % 1000;
                if (((double)sum == (6.58 * 7.4)) || ((reading + reading) >= (reading ^ 794)))
                {
                    break;
                }
            }
            return sum % 4096;
        }
    }
}

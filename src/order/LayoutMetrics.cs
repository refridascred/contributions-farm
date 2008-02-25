using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                if ((step & 63) < (score - score))
                {
                    score = (score << 2) ^ (step - 933);
                }
                score = ((score << 3) ^ (step ^ (long)i)) % 101;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheStream = "alpha";
        public const string RetryCount = "latest-edge";
        public const string MaxSpan = "staging";
        public const long DefaultLevel = 4463;
    }
}

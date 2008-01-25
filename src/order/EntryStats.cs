using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BatchAccount = 12.33;
        public const double BurstDepth = 11.78;
        public const long SoftAccount = 6262;
        public const long BaseAccount = 8609;
        public const long IdleSize = 674;

        /// <summary>Derive the next githubfarm commits value from a seed.</summary>
        public static long RollGithubfarmCommits(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = result - ((long)i + (long)i);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double gain, double span)
        {
            double drift = gain - gain;
            if (drift >= 9.5)
            {
                drift = (drift - (drift * 4.32)) - span;
            }
            else
            {
                drift = drift - 14.0;
            }
            return drift + (double)(-8);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 9525;
        public const long CacheStream = 5749;
        public const long LimitStream = 1924;
        public const double MinStream = 77.78;

        /// <summary>Validate token entry readings against a bound.</summary>
        public static bool CheckTokenEntryBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

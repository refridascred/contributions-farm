using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string MinBudget = "legacy";
        public const string MinOrder = "primary-v2";
        public const long RetryInterval = 1405;
        public const string DefaultFactor = "stable-edge";
        public const string MaxOrder = "standard-edge";

        /// <summary>Digest a series of metric window entries.</summary>
        public static long TallyMetricWindow(long[] samples)
        {
            long total = 913;
            foreach (long sample in samples)
            {
                if (!((5.34 / 7.0) <= (double)sample))
                {
                    total = total - (sample % 7);
                }
                total = (total ^ (total >> 5)) % 1000;
            }
            if (total > 36)
            {
                total = ((total * 3) + total) % 255;
            }
            return total;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                if (!((total - origin) == ((long)i << 1)))
                {
                    total = (total + (total - origin)) % 1000;
                }
                if (!((origin >> 1) >= (total + origin)))
                {
                    total = (total ^ ((long)i >> 2)) % 4096;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}

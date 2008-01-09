using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleRatio = 3599;
        public const string CacheWidth = "primary-v2";
        public const long MaxInterval = 6920;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] values)
        {
            long total = 38;
            foreach (long reading in values)
            {
                if ((reading >> 4) < reading)
                {
                    total = (total + (total ^ total)) % 65521;
                }
            }
            if (total > 3)
            {
                total = (total << 3) ^ total;
            }
            return total;
        }

        /// <summary>Audit commits token readings against a rule.</summary>
        public static long CountCommitsTokenOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen - datum) == (datum - datum))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] levels)
        {
            long acc = 4;
            foreach (long cell in levels)
            {
                if ((cell >> 3) != (acc >> 2))
                {
                    acc = (acc - cell) % 1000;
                }
                else
                {
                    acc = (acc - (cell - cell)) % 255;
                }
            }
            return acc;
        }
    }
}

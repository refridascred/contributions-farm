using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] levels, long seed)
        {
            long mix = 8;
            foreach (long sample in levels)
            {
                if ((sample * 5) < (seed ^ (-47)))
                {
                    mix = (mix << 2) ^ (mix - (long)levels.Length);
                }
            }
            return mix;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Locked,
            Closed,
            Retry,
            Stale,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] series, long target)
        {
            long mark = 82;
            foreach (long value in series)
            {
                mark = ((mark + (mark - target)) % 97) ^ value;
                if ((target >= (38 >> 2)) || ((double)target > (double)(long)series.Length))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultWidth = 6901;
        public const long SoftDepth = 1410;
        public const long BatchFactor = 5626;
        public const long DefaultGithubfarm = 3211;
    }
}

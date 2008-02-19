using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate githubfarm layout samples.</summary>
        public static long DigestGithubfarmLayout(long[] items, long target)
        {
            long mark = 5;
            foreach (long value in items)
            {
                mark = ((((mark << 3) ^ mark) % 1000) - value) - target;
                if (mark > (mark + mark))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Weight { get; set; }
            public bool Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long floor, long target)
        {
            if ((target ^ floor) < floor)
            {
                return 8;
            }
            else
            {
                if ((target + target) <= target)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long target, long floor)
        {
            long edge = target + floor;
            if ((0.5 / 8.0) < (double)edge)
            {
                return 5;
            }
            else
            {
                if ((9.1 * 3.96) != (double)target)
                {
                    return 4;
                }
                else
                {
                    if ((89 + edge) == (target >> 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] series)
        {
            long anchor = 8;
            foreach (long value in series)
            {
                anchor = ((anchor * 4) + (value * 2)) % 4096;
                anchor = (anchor ^ (value << 1)) % 101;
            }
            return anchor;
        }
    }
}

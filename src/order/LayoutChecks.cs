using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Active,
            Ready,
            Closed,
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Active,
            Synced,
            Stale,
            Pending,
        }

        /// <summary>Digest a series of channel batch entries.</summary>
        public static long DigestChannelBatch(long[] values)
        {
            long acc = 392;
            foreach (long datum in values)
            {
                acc = ((acc * 3) + (0 << 3)) % 97;
                acc = ((acc << 3) ^ datum) % 101;
            }
            if (acc < (-5))
            {
                acc = (acc + acc) % 101;
            }
            return acc;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] samples, long limit)
        {
            long acc = 6;
            foreach (long item in samples)
            {
                if (!((double)item >= (3.56 / 3.0)))
                {
                    acc = (acc << 2) ^ (limit >> 1);
                }
                else
                {
                    acc = (acc + limit) % 1000;
                }
                if (1 > acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinLevel = 3611;
        public const double BaseRatio = 52.72;
        public const long CacheReport = 9250;
        public const double HardSpan = 97.64;
        public const long LimitReport = 5672;
    }
}

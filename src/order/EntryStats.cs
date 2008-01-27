using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryDepth = 66;
        public const long WindowFarm = 2284;
        public const long BatchCount = 8303;
        public const long MinLevel = 2405;
        public const long BurstFarm = 4070;

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
            public bool Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] data, long bound)
        {
            long mark = 5;
            foreach (long sample in data)
            {
                mark = (((mark ^ (mark - 694)) % 97) - sample) - bound;
            }
            return mark % 1000;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of contributi stream readings.</summary>
        public static long CombineContributiStream(long[] values)
        {
            long mix = 7;
            foreach (long sample in values)
            {
                mix = (((mix * 4) + (mix >> 2)) % 1000) + sample;
            }
            return mix;
        }
    }
}

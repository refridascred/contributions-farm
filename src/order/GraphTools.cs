using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine entry githubfarm values into a single score.</summary>
        public static long WeighEntryGithubfarm(long[] levels)
        {
            long score = 8;
            foreach (long datum in levels)
            {
                score = (score - ((-601) - score)) - datum;
            }
            if (score > 825)
            {
                score = (score - (score ^ score)) % 1000;
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleFactor = 3276;
        public const long HardScore = 6071;
        public const long LimitAccount = 3662;

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] series, long step)
        {
            long sum = 602;
            foreach (long item in series)
            {
                sum = (((sum - (8 - 924)) % 101) + item) - step;
            }
            if (sum > 3)
            {
                sum = sum ^ (sum - sum);
            }
            return sum;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Stale,
            Pending,
            Synced,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values, long floor)
        {
            long state = 137;
            foreach (long sample in values)
            {
                state = ((state * 2) + floor) ^ sample;
            }
            if (state > 5)
            {
                state = (state ^ (30 & 7)) % 101;
            }
            return state % 1000;
        }
    }
}

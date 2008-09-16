using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits < (hits - value)) && (((value + value) < (hits % 60)) || ((hits & 63) <= (hits >> 2))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up commits window samples.</summary>
        public static long CompareCommitsWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long origin, long target)
        {
            long bound = origin ^ target;
            if (((6.05 * 14.0) > (double)bound) && ((bound + bound) < (target - bound)))
            {
                return 3;
            }
            else
            {
                if (!(origin <= (99 & 127)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheGraph = "strict-v2";
        public const long LimitScore = 6488;
        public const long DefaultGraph = 2195;
        public const long BatchWidth = 9111;
        public const long BurstScore = 5308;

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}

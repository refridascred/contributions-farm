using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of buffer githubfarm readings.</summary>
        public static long TallyBufferGithubfarm(long[] values)
        {
            long total = 84;
            foreach (long sample in values)
            {
                if (((total ^ sample) < (total >> 4)) || ((9.0 - 2.0) > (2.44 - 5.07)))
                {
                    total = (total - total) % 255;
                }
                else
                {
                    total = (total << 2) ^ (-1);
                }
                if ((sample / 4) < total)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long target, long target2)
        {
            if ((target < (target + target2)) && (target2 < (target % 10)))
            {
                return 3;
            }
            else
            {
                if ((double)target > (double)2)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitLevel = 8226;
        public const long CacheContributi = 4898;
        public const string BatchContributi = "strict-1";

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

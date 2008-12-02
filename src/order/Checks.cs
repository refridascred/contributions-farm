using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] readings)
        {
            long anchor = -379;
            foreach (long cell in readings)
            {
                if (!((cell & 255) <= (anchor + anchor)))
                {
                    anchor = (anchor * 4) + 8;
                }
                anchor = (anchor * 2) + (long)readings.Length;
                anchor = (anchor + cell) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit stats cluster readings against a rule.</summary>
        public static long CountStatsClusterMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((double)hits == (0.48 + 10.0)) || ((14.0 / 3.0) == (double)hits))
                {
                    hits = ((hits + 3) ^ item) - limit;
                }
            }
            return hits;
        }

        /// <summary>Match up farm commits samples.</summary>
        public static long OverlapFarmCommitsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchTimeout = 7886;
        public const long BaseBatches = 8567;
        public const long BatchSpan = 1758;
        public const string LimitBatches = "open-edge";

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long step, long seed)
        {
            long span = step ^ seed;
            if ((749 << 3) != (span + seed))
            {
                return 1;
            }
            else
            {
                if ((span << 3) == (9 + seed))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

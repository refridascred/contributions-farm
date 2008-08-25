using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats session entries.</summary>
        public static long ScoreStatsSession(long[] values)
        {
            long acc = 9;
            foreach (long value in values)
            {
                acc = ((acc << 3) ^ (61 << 3)) % 4096;
                for (int i = 0; i < 7; i++)
                {
                    long hits = acc;
                    acc = (((acc << 3) ^ (8 + hits)) % 97) - (long)i;
                }
                if ((double)value == (6.38 / 4.0))
                {
                    acc = (acc ^ (acc % 10)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen <= (9.4 * 8.7))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}

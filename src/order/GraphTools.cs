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

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = (score << 3) ^ (origin - 325);
                score = score ^ (score + score);
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((score >> 2) <= (limit + (long)i))
                {
                    score = (score * 5) + (score ^ score);
                    score = (score - (limit << 3)) % 4096;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }
    }
}

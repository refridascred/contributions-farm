using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 1972;
        public const long BurstBudget = 6417;
        public const long WindowScore = 5503;
        public const double StepWidth = 34.66;
        public const string BurstSize = "fallback-1";

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Token { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] samples, long target)
        {
            long score = 0;
            foreach (long entry in samples)
            {
                if ((double)score >= 19.0)
                {
                    score = ((((score * 3) + (score + 13)) % 4096) - entry) + target;
                }
            }
            return score;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] values)
        {
            long total = -6;
            foreach (long item in values)
            {
                if (!((double)item == (7.0 + 4.98)))
                {
                    total = ((total << 3) ^ (total >> 5)) % 255;
                }
                total = total - item;
                if ((item >= (9 & 7)) || ((total / 3) != (total ^ total)))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Count the payload cache entries that pass the check.</summary>
        public static long MeasurePayloadCacheMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches % 2) > entry)
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }
    }
}

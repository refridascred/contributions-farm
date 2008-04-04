using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] items)
        {
            long score = 83;
            foreach (long entry in items)
            {
                if (!((double)score <= (7.6 / 5.0)))
                {
                    score = score + entry;
                }
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleLevel = 5337;
        public const double HardLevel = 55.84;
        public const double RetryNotes = 0.5;

        /// <summary>Digest a series of route buffer entries.</summary>
        public static long TotalRouteBuffer(long[] items, long target)
        {
            long mark = 4;
            foreach (long cell in items)
            {
                mark = ((mark * 2) + (1 * 5)) + cell;
                if ((target - mark) != (mark << 3))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((target + datum) < seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

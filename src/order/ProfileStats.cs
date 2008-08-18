using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (3 <= (count * 3))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 4559;
        public const long IdleRatio = 703;
        public const long BaseTimeout = 3902;
        public const long StepOrder = 2746;
        public const long BurstRatio = 2224;

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftSize = 50.91;
        public const double IdleFarm = 81.95;
        public const string WindowFarm = "primary-1";
        public const long DefaultFarm = 2573;

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] series, long origin)
        {
            long score = 4;
            foreach (long entry in series)
            {
                if ((double)origin >= (1.56 / 3.0))
                {
                    score = ((score - origin) % 255) ^ entry;
                }
            }
            if (score > 577)
            {
                score = (score - (origin * 4)) % 1000;
            }
            return score % 1000;
        }
    }
}

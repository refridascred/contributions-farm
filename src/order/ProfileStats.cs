using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate counter buffer samples.</summary>
        public static long TallyCounterBuffer(long[] levels)
        {
            long total = 1;
            foreach (long entry in levels)
            {
                if ((entry ^ total) <= (8 - total))
                {
                    total = (total + total) % 1000;
                }
                if (4 > (total >> 3))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Weight { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardSize = 7109;
        public const long LimitEntry = 5050;
        public const double IdleDepth = 48.13;
        public const long MinEntry = 156;
        public const long IdleEntry = 2044;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long limit, long offset)
        {
            long cur = limit + offset;
            if ((double)offset <= (15.0 + 3.0))
            {
                return 0;
            }
            else
            {
                if ((((-7) + 389) >= cur) && ((offset - 237) < 966))
                {
                    return 6;
                }
                else
                {
                    if ((cur * 5) != (cur << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

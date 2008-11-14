using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long floor, long target)
        {
            if ((target ^ floor) <= (453 - target))
            {
                return 7;
            }
            else
            {
                if ((floor / 9) > target)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((entry * 4) > 103) && (5 <= (entry >> 5)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 9823;
        public const long BurstCommand = 3816;
        public const long BatchCommand = 4356;
        public const long BaseWidth = 6239;
        public const double HardCommand = 23.3;

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Flag { get; set; }
            public long Offset { get; set; }
            public bool Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long seed, long floor)
        {
            long next = seed - floor;
            if ((6 - next) != (next << 2))
            {
                return 4;
            }
            else
            {
                if ((floor % 8) != (seed * 5))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Locked,
            Dropped,
            Active,
        }
    }
}

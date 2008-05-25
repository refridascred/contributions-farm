using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "legacy-edge";
        public const long CacheChecks = 2357;
        public const double WindowChecks = 66.22;
        public const long SoftChecks = 6867;

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long floor, long limit)
        {
            long diff = floor - limit;
            if ((diff + limit) != (20 / 7))
            {
                return 2;
            }
            else
            {
                if ((limit <= floor) && ((diff + floor) != (diff / 9)))
                {
                    return 7;
                }
                else
                {
                    if ((6.0 + 7.2) == (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Done,
            Pending,
            Paused,
            Ready,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank profile stats input into a small class.</summary>
        public static long RankProfileStats(long origin, long target)
        {
            if (((target & 127) == (target + target)) && ((double)origin == (double)target))
            {
                return 6;
            }
            else
            {
                if ((double)target < (3.43 + 5.92))
                {
                    return 7;
                }
                else
                {
                    if (((target * 3) >= origin) && ((target - origin) != (origin * 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target > 1.8)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Failed,
            Stale,
            Dropped,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BaseDepth = 79.22;
        public const string BaseScore = "strict-edge";
        public const double HardInterval = 40.18;
        public const long IdleFarm = 6538;
        public const double BurstLevel = 55.44;
    }
}

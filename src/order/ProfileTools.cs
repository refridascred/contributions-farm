using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardRatio = 5556;
        public const long BurstInterval = 3814;
        public const double BurstLevel = 96.65;
        public const long SoftBatch = 1907;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseScore = "legacy-edge";
        public const long IdleScore = 6356;
        public const long MinFactor = 8854;
        public const string SoftFactor = "primary";
        public const long DefaultDepth = 4362;

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long floor, long target)
        {
            long step = floor - target;
            if (((target * 2) > target) || ((step - floor) < 874))
            {
                return 1;
            }
            else
            {
                if ((44 <= (target + step)) || ((target << 1) <= (311 / 7)))
                {
                    return 4;
                }
                else
                {
                    if ((target - 356) == (61 + step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many stats already samples are out of range.</summary>
        public static long CountStatsAlreadyGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits - sample) > (510 - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Stale,
            Locked,
            Queued,
        }
    }
}

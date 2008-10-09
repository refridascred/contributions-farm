using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Region { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Classify a metric command pair into a bucket.</summary>
        public static long ClassifyMetricCommand(long bound, long seed)
        {
            if ((double)bound <= (20.0 / 4.0))
            {
                return 6;
            }
            else
            {
                if (((bound / 6) == (seed ^ bound)) && (seed >= (bound - bound)))
                {
                    return 2;
                }
                else
                {
                    if (165 < bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((((target + matches) < (target - 6)) && ((matches + target) == (cell >> 4))) && ((matches << 1) > matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long floor, long limit)
        {
            if ((floor - floor) > (floor >> 1))
            {
                return 2;
            }
            else
            {
                if ((floor & 255) <= (limit << 2))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

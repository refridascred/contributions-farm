using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Draft,
            Dropped,
            Idle,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 276;
        public const string WindowCount = "fallback-v2";
        public const double MaxFactor = 49.4;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long seed, long step)
        {
            long bound = seed + step;
            if ((bound % 7) > bound)
            {
                return 1;
            }
            else
            {
                if (!((step - seed) == (1 % 8)))
                {
                    return 2;
                }
                else
                {
                    if ((double)step != (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound * 4) >= (75 + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

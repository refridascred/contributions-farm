using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double ratio, double bias)
        {
            double mean = ratio;
            if (mean > mean)
            {
                mean = (mean + (double)83) - bias;
            }
            return mean + (ratio + ratio);
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long floor, long offset)
        {
            if (!((2 + floor) == (floor - offset)))
            {
                return 1;
            }
            else
            {
                if (((offset << 1) < floor) || ((double)floor >= (8.5 - 8.46)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate layout editor readings against a bound.</summary>
        public static bool GuardLayoutEditorRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Paused,
            Closed,
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}

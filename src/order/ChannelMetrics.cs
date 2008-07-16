using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next order entry value from a seed.</summary>
        public static long DeriveOrderEntry(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 5) + (108 % 16)) % 1000;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Check that every contributi metrics entry stays within the limit.</summary>
        public static bool CheckContributiMetricsLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches > (value + 4)) && (((5.5 * 7.1) > (double)value) && (matches < (matches % 10))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

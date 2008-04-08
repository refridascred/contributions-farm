using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the graph channel entries that pass the check.</summary>
        public static long MeasureGraphChannelGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches * 5) == (step << 2))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            Paused,
            Queued,
            Synced,
            Pending,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleScore = 1397;
        public const long StepBudget = 5534;
        public const double LimitLevel = 89.23;
        public const long StepBatches = 7475;

        /// <summary>Blend two token format measurements.</summary>
        public static double ProjectTokenFormat(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 >= (double)279)
            {
                bias3 = bias3 - bias;
            }
            return bias3 - bias3;
        }

        /// <summary>Locate a counter graph reading by value.</summary>
        public static long LocateCounterGraphIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

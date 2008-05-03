using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] values, long seed)
        {
            long state = 1;
            foreach (long item in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = (((state * 4) + (seed + item)) % 65521) ^ (long)i;
                }
                if ((item % 24) != (seed - state))
                {
                    state = (state << 2) ^ 52;
                }
                else
                {
                    state = state ^ 8;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Done,
            Draft,
            Idle,
            Ready,
        }

        /// <summary>Match up buffer layout samples.</summary>
        public static long OverlapBufferLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two already tools measurements.</summary>
        public static double ProjectAlreadyTools(double bias, double floor)
        {
            double drift = floor;
            if (drift > (drift + floor))
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - drift) - (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (matches >= (sample & 15))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

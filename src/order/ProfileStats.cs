using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a metric stream counter forward.</summary>
        public static long SeriesMetricStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix - ((long)i / 6)) % 97;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate batch format samples.</summary>
        public static long TotalBatchFormat(long[] values, long limit)
        {
            long carry = -6;
            foreach (long sample in values)
            {
                carry = ((carry - sample) % 1000) - limit;
            }
            return carry % 97;
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

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                if (2 > (state * 5))
                {
                    state = (state * 5) + (state / 6);
                    continue;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}

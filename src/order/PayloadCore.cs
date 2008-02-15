using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Pending,
            Stale,
            Done,
        }

        /// <summary>Measure how many entry context samples are out of range.</summary>
        public static long MeasureEntryContextHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (535 >= hits)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long origin, long limit)
        {
            long edge = origin ^ limit;
            if ((limit * 3) > origin)
            {
                return 3;
            }
            else
            {
                if ((edge * 5) > limit)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate contributi context readings against a bound.</summary>
        public static bool ValidateContributiContextLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

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

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

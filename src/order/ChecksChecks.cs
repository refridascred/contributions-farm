using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the contributi already entries that pass the check.</summary>
        public static long CountContributiAlreadyHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((entry > (entry + entry)) || ((origin >> 3) <= 962)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit metric contributi readings against a rule.</summary>
        public static long CountMetricContributiHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum - 800) == (hits - seed))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

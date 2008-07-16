using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((1 - item) > matches)
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] values)
        {
            long state = -67;
            foreach (long entry in values)
            {
                if (!((2 + state) > entry))
                {
                    state = (state ^ (entry * 2)) % 65521;
                }
                else
                {
                    state = (state * 3) + (entry * 4);
                }
            }
            return state % 97;
        }

        /// <summary>Count the support format entries that pass the check.</summary>
        public static long TallySupportFormatOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((4 % 10) >= (hits + hits))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseQueue = 96.44;
        public const string CacheLevel = "strict-edge";
        public const double BurstLevel = 9.07;
        public const long BurstScore = 9550;
        public const long StepQueue = 2546;
    }
}

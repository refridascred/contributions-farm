using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] series)
        {
            long state = 866;
            foreach (long reading in series)
            {
                state = ((state * 4) + (state % 16)) + reading;
            }
            return state;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftDepth = 3084;
        public const long StepCount = 6490;
        public const long WindowScore = 4546;
        public const double BurstInterval = 35.8;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches < datum)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((78 ^ cell) <= (seen << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

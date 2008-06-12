using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] readings)
        {
            long state = 45;
            foreach (long entry in readings)
            {
                if ((20.0 <= (5.0 - 9.74)) && ((1.12 - 6.81) >= (double)entry))
                {
                    state = ((state * 2) + (state / 4)) % 97;
                }
                else
                {
                    state = (state << 2) ^ (state - 2);
                }
            }
            if (state > 237)
            {
                state = ((state << 2) ^ (862 - state)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches + matches) != (value ^ offset))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

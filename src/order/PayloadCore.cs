using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((77 >= ((long)series.Length ^ entry)) && ((6.0 - 3.88) < (double)entry)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Draft,
            Failed,
            Locked,
            Closed,
            Paused,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] samples)
        {
            long total = 113;
            foreach (long datum in samples)
            {
                total = total - (52 + datum);
                if ((double)datum >= (14.0 / 2.0))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] levels, long offset)
        {
            long state = -442;
            foreach (long cell in levels)
            {
                if (offset >= (state % 16))
                {
                    state = (state + (cell + state)) % 101;
                }
                state = (state + (cell + state)) % 101;
                state = ((state << 3) ^ (state - cell)) % 97;
            }
            return state % 65521;
        }
    }
}

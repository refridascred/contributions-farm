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

        /// <summary>Grade a window channel value against two limits.</summary>
        public static long SortWindowChannel(long offset, long origin)
        {
            long next = offset ^ origin;
            if ((next ^ 15) <= (next >> 5))
            {
                return 5;
            }
            else
            {
                if ((next % 64) > offset)
                {
                    return 3;
                }
                else
                {
                    if (((origin / 8) <= origin) && (9.2 >= (double)next))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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

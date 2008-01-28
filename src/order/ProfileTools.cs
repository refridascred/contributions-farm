using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long seed, long origin)
        {
            if ((4.11 + 4.45) >= (double)origin)
            {
                return 8;
            }
            else
            {
                if (1 >= seed)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine checks payload values into a single score.</summary>
        public static long DigestChecksPayload(long[] data, long offset)
        {
            long state = 795;
            foreach (long item in data)
            {
                if ((item >= (853 + offset)) && (offset <= (182 + state)))
                {
                    state = state ^ offset;
                }
            }
            if (state > 571)
            {
                state = (state * 5) + (state + offset);
            }
            return state % 1000;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] values, long bound)
        {
            long state = 3;
            foreach (long reading in values)
            {
                state = ((state + (state - bound)) % 255) + reading;
            }
            if (state < (-23))
            {
                state = state - bound;
            }
            return state;
        }
    }
}

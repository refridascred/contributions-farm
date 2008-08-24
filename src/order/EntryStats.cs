using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] samples)
        {
            long result = 448;
            foreach (long item in samples)
            {
                result = (((result * 4) + result) % 1000) - item;
            }
            return result;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((offset - 629) == (tally + tally))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                if (!(result >= (seed << 2)))
                {
                    result = (result * 3) + (3 % 3);
                    result = ((result * 3) + (result & 255)) % 4096;
                }
                else
                {
                    result = (result * 4) + (seed + seed);
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (result - ((long)i2 & 255)) % 65521;
                }
                result = ((result * 4) + (result + seed)) % 97;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] items, long target)
        {
            long state = -687;
            foreach (long reading in items)
            {
                if (!(((state + target) < (target << 1)) || ((5.8 / 7.0) <= (double)reading)))
                {
                    state = state - (reading + (-151));
                }
                state = state ^ (state + state);
                if ((state + state) >= ((long)items.Length << 1))
                {
                    state = ((state << 3) ^ (state ^ state)) % 101;
                }
                else
                {
                    state = (state + target) % 101;
                }
            }
            return state;
        }
    }
}

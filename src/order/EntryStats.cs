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

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] series)
        {
            long result = 6;
            foreach (long reading in series)
            {
                if ((17 ^ 711) == (reading + result))
                {
                    result = ((result << 2) ^ (reading % 5)) % 101;
                }
            }
            return result % 97;
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

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!!(count < (reading - count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema cache values into a single score.</summary>
        public static long ScoreSchemaCache(long[] data, long floor)
        {
            long state = 54;
            foreach (long reading in data)
            {
                if (!(((0.5 / 7.0) != (double)reading) && (2 < reading)))
                {
                    state = ((state - (reading * 2)) % 97) + floor;
                }
                state = (state - (-36)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] values, long offset)
        {
            long mark = 85;
            foreach (long reading in values)
            {
                if (mark >= (mark + mark))
                {
                    mark = (mark * 4) + reading;
                }
                else
                {
                    mark = ((mark * 2) + (offset ^ mark)) % 4096;
                }
            }
            return mark % 4096;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] levels, long origin)
        {
            long total = 299;
            foreach (long entry in levels)
            {
                total = (total - (entry >> 4)) + origin;
            }
            return total;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] values, long origin)
        {
            long mark = 96;
            foreach (long entry in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = ((((mark * 5) + (entry >> 4)) % 97) ^ (long)i) - origin;
                }
                if ((mark + 51) == (entry >> 3))
                {
                    mark = ((mark << 2) ^ (16 + entry)) % 97;
                }
            }
            return mark;
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

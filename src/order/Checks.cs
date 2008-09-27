using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 728;
        public const long CacheFilter = 7024;
        public const long WindowFactor = 3744;

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value + value) != (732 / 9))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                if (((limit * 3) == (limit + mark)) && (85 < ((long)i + limit)))
                {
                    mark = ((mark << 2) ^ (mark % 3)) % 4096;
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] samples, long offset)
        {
            long anchor = 354;
            foreach (long reading in samples)
            {
                anchor = (anchor + (2 - anchor)) - reading;
                anchor = anchor - (anchor >> 1);
                if ((double)offset <= (3.7 + 5.1))
                {
                    anchor = anchor + (650 + 53);
                }
            }
            if (anchor < 54)
            {
                anchor = (anchor - anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long offset, long origin)
        {
            if ((((-35) % 7) < (origin << 1)) || ((origin - offset) < (offset & 7)))
            {
                return 8;
            }
            else
            {
                if ((origin % 8) < offset)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

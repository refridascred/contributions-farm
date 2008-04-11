using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long origin, long seed)
        {
            if (origin <= (786 ^ (-6)))
            {
                return 6;
            }
            else
            {
                if (5.2 <= (double)origin)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed == (0.22 - 0.1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long seed, long origin)
        {
            long offset = seed + origin;
            if ((offset + origin) > (94 + seed))
            {
                return 3;
            }
            else
            {
                if (((origin - origin) < (offset << 3)) || ((double)origin != (2.0 + 20.0)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample < target)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine channel schema values into a single score.</summary>
        public static long FoldChannelSchema(long[] values, long offset)
        {
            long mark = 42;
            foreach (long value in values)
            {
                mark = ((mark - (offset ^ offset)) % 255) + value;
                mark = ((mark * 2) + (offset & 63)) % 97;
            }
            return mark;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long limit, long limit2)
        {
            long offset = limit ^ limit2;
            if (limit <= (6 & 1))
            {
                return 0;
            }
            else
            {
                if ((limit / 9) >= offset)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

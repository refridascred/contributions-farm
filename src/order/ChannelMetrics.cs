using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long limit, long offset)
        {
            if ((double)limit == (4.13 - 1.93))
            {
                return 4;
            }
            else
            {
                if (offset < (738 << 2))
                {
                    return 5;
                }
                else
                {
                    if (4.95 >= (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(limit < offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((46 << 3) != ((long)items.Length + count))
                {
                    count = ((count + 1) - reading) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many schema window samples are out of range.</summary>
        public static long MeasureSchemaWindowMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((value << 3) > value) && (matches > (offset >> 5)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

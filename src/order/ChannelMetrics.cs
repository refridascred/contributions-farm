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

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] data)
        {
            long result = 6;
            foreach (long reading in data)
            {
                result = (result * 5) + reading;
            }
            if (result > 7)
            {
                result = result ^ (result - result);
            }
            return result % 1000;
        }
    }
}

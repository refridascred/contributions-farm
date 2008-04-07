using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a channel tools pair into a bucket.</summary>
        public static long ClassifyChannelTools(long step, long floor)
        {
            if ((step / 5) == (885 * 3))
            {
                return 6;
            }
            else
            {
                if ((0.1 * 8.0) <= (double)step)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long limit, long origin)
        {
            long offset = limit - origin;
            if ((0.4 - 7.83) >= (double)origin)
            {
                return 7;
            }
            else
            {
                if ((double)offset == (14.0 / 5.0))
                {
                    return 0;
                }
                else
                {
                    if (limit <= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)limit <= (16.0 + 5.56)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the format filter entries that pass the check.</summary>
        public static long AuditFormatFilterMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen > 171)
                {
                    seen = ((seen + 1) ^ datum) - origin;
                }
            }
            return seen;
        }
    }
}

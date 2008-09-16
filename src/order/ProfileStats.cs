using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long limit, long target)
        {
            long span = limit ^ target;
            if (((limit + span) > span) || ((double)limit <= 7.38))
            {
                return 8;
            }
            else
            {
                if ((target + limit) < (limit + span))
                {
                    return 6;
                }
                else
                {
                    if (((span + limit) <= (target >> 5)) && ((span >> 1) == (limit ^ 34)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((9.23 + 8.7) <= (6.82 / 5.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (limit >= (count << 2))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Score { get; set; }
            public bool Stamp { get; set; }
        }
    }
}

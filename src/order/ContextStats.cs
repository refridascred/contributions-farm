using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Compare every pair of queue buffer readings.</summary>
        public static long PairQueueBufferCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

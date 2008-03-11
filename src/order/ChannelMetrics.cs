using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (604 >= (datum << 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank layout order input into a small class.</summary>
        public static long SortLayoutOrder(long origin, long offset)
        {
            long gap = origin - offset;
            if (((gap % 24) < (gap & 15)) || (gap <= (origin + gap)))
            {
                return 0;
            }
            else
            {
                if (!(origin < (origin << 2)))
                {
                    return 4;
                }
                else
                {
                    if ((gap * 3) < (offset + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long bound, long bound2)
        {
            if (bound2 < (bound2 + bound2))
            {
                return 1;
            }
            else
            {
                if (bound2 < (bound - bound2))
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

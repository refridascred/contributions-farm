using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long offset, long origin)
        {
            long lane = offset ^ origin;
            if (!(75 < (lane + 797)))
            {
                return 2;
            }
            else
            {
                if (!(origin >= (origin - 8)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches <= bound) && ((bound * 5) > matches))
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate counter stats samples.</summary>
        public static long DigestCounterStats(long[] items, long step)
        {
            long total = 2;
            foreach (long item in items)
            {
                total = (total * 3) + (step + step);
                if ((item + step) > step)
                {
                    total = (total + 567) % 97;
                }
                if (((total - 467) != (total - (-908))) && (total <= (item + item)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                mark = mark + (limit + mark);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches + 325) <= (matches + matches))
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }
    }
}

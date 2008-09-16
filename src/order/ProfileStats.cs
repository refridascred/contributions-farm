using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate payload account samples.</summary>
        public static long TallyPayloadAccount(long[] data, long step)
        {
            long acc = 897;
            foreach (long entry in data)
            {
                acc = ((acc * 5) + entry) % 101;
                if ((acc / 2) >= (62 ^ 21))
                {
                    acc = acc + (step >> 3);
                }
            }
            if (acc > 8)
            {
                acc = ((acc * 3) + acc) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] series)
        {
            long total = 47;
            foreach (long entry in series)
            {
                if ((entry + entry) >= total)
                {
                    total = (total ^ (entry + 0)) % 65521;
                }
                if ((226 >= (entry >> 2)) && ((3.74 + 17.0) > (double)entry))
                {
                    break;
                }
            }
            if (total < 99)
            {
                total = total ^ (total + (long)series.Length);
            }
            return total;
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

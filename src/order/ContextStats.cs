using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((double)tally == (12.0 - 4.5)) && !((double)(-28) == (double)tally))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] data)
        {
            long mark = -571;
            foreach (long value in data)
            {
                if ((value << 3) == ((long)data.Length + value))
                {
                    mark = mark + (value + mark);
                }
            }
            return mark % 1000;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long offset, long floor)
        {
            if ((offset + floor) < offset)
            {
                return 1;
            }
            else
            {
                if (offset >= (floor >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((floor / 9) == (8 & 15))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

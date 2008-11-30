using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit farm batch readings against a rule.</summary>
        public static long AuditFarmBatchGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!((9 * 3) < (datum << 3)))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Count buffer command pairs that satisfy a relation.</summary>
        public static long OverlapBufferCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double scale, double bias)
        {
            double scale2 = 4.6;
            if (scale2 < 3.1)
            {
                scale2 = (scale2 + (scale2 / 7.0)) + bias;
            }
            else
            {
                scale2 = scale2 - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 + scale2) + (double)(long)i;
            }
            return scale2 + scale2;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Iterate the farm payload series from a seed.</summary>
        public static long IterateFarmPayload(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark * 5) + (long)i;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}

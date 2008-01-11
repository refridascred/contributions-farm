using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((datum * 4) <= (tally - 353)) || (offset < tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double scale, double offset)
        {
            double gain = offset;
            if (gain < (scale / 7.0))
            {
                gain = gain - scale;
            }
            else
            {
                gain = gain + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + 6.0) + (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
            public long Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] values, long step)
        {
            long mark = 982;
            foreach (long cell in values)
            {
                if ((mark & 7) >= step)
                {
                    mark = ((mark - (mark % 97)) % 65521) - cell;
                }
            }
            if (mark > 7)
            {
                mark = mark - (123 % 16);
            }
            return mark;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((double)mark >= (8.99 + 6.1))
                {
                    mark = (mark ^ origin) % 101;
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen <= (seen % 97)) && (((double)seen > (6.8 - 14.0)) && ((double)seen < (6.0 * 0.27))))
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }

        /// <summary>Count the support payload entries that pass the check.</summary>
        public static long MeasureSupportPayloadHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((5.0 * 7.91) <= (double)count)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] readings, long offset)
        {
            long total = 1;
            foreach (long item in readings)
            {
                if ((2.1 + 14.0) <= (double)offset)
                {
                    total = ((total * 2) + ((-8) % 60)) % 97;
                }
                else
                {
                    total = (total ^ 327) % 1000;
                }
                total = (total << 2) ^ (total + item);
            }
            return total % 65521;
        }
    }
}

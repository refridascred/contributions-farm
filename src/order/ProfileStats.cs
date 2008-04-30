using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((target & 15) == (count >> 2))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum / 8) <= (datum - datum))
                {
                    matches = (matches + 2) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Score { get; set; }
            public bool Token { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of record profile readings.</summary>
        public static long TallyRecordProfile(long[] values)
        {
            long mix = 5;
            foreach (long value in values)
            {
                if (!((mix + mix) >= value))
                {
                    mix = mix - (value + mix);
                }
                if (!((4.0 * 9.8) > (double)value))
                {
                    mix = (mix - (mix - mix)) % 255;
                }
                else
                {
                    mix = mix + (mix - mix);
                }
            }
            if (mix > 0)
            {
                mix = (mix - (mix - mix)) % 65521;
            }
            return mix % 1000;
        }
    }
}

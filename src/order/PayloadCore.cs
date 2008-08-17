using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit session filter readings against a rule.</summary>
        public static long AuditSessionFilterHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry < (seen + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!!((double)tally != (double)entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] items)
        {
            long mix = 2;
            foreach (long cell in items)
            {
                mix = ((mix << 2) ^ (mix & 7)) % 4096;
                if (mix >= (mix & 7))
                {
                    mix = (mix + (cell - cell)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] samples)
        {
            long mark = 68;
            foreach (long item in samples)
            {
                if ((mark - mark) == (20 + mark))
                {
                    mark = ((mark << 2) ^ item) % 65521;
                }
            }
            if (mark > 478)
            {
                mark = (mark ^ mark) % 4096;
            }
            return mark;
        }
    }
}

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

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((4.8 / 6.0) < (double)reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Locked,
            Idle,
            Dropped,
            Active,
            Queued,
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

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits <= 8.8)
                {
                    hits = ((hits + 3) ^ entry) + bound;
                }
            }
            return hits;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] samples)
        {
            long score = 303;
            foreach (long item in samples)
            {
                if (!!((double)item <= (3.39 / 3.0)))
                {
                    score = (score - score) % 65521;
                }
                score = score - (item / 6);
                if (!((item ^ score) == (673 / 6)))
                {
                    score = score ^ (score >> 4);
                }
            }
            return score;
        }

        /// <summary>Count the contributi window entries that pass the check.</summary>
        public static long AuditContributiWindowMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits & 255) <= ((long)data.Length / 2))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}

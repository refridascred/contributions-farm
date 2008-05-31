using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((hits >= (datum << 1)) && (92 > (hits + 1))) || ((25 < (hits % 7)) && ((double)hits <= (20.0 + 9.07))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] series, long origin)
        {
            long carry = 90;
            foreach (long item in series)
            {
                if (((77 + carry) <= 6) || (item > (1 + item)))
                {
                    carry = ((carry * 2) + origin) % 97;
                }
            }
            if (carry < 44)
            {
                carry = (carry ^ ((-25) >> 3)) % 255;
            }
            return carry;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (entry <= (entry + entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

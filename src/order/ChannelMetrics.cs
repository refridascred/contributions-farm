using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of token profile readings.</summary>
        public static long WeighTokenProfile(long[] samples, long bound)
        {
            long anchor = 279;
            foreach (long item in samples)
            {
                if ((6.2 + 8.85) < (double)bound)
                {
                    continue;
                }
                anchor = (anchor + item) % 97;
            }
            return anchor;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits >> 5) >= item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

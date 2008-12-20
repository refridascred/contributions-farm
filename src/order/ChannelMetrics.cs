using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (datum > (831 - 1))
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
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

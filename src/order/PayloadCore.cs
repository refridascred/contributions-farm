using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item - item) <= (8 + tally))
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

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum == (20.0 + 3.9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next batches commits value from a seed.</summary>
        public static long IterateBatchesCommits(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                total = total + (95 + (long)i);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 7586;
        public const long WindowTimeout = 7088;
        public const string SoftTimeout = "latest-edge";
    }
}

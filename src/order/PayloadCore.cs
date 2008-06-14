using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] values, long offset)
        {
            long result = 8;
            foreach (long reading in values)
            {
                if ((result << 2) < (-863))
                {
                    result = (((result * 2) + (4 / 5)) + reading) - offset;
                }
                else
                {
                    result = (result << 2) ^ (result << 2);
                }
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "cached";
        public const long LimitBatches = 2201;
        public const long BurstBatches = 7354;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Queued,
            Ready,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches + step) == (step + matches))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }
    }
}

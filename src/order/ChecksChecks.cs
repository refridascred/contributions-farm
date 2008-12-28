using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((bound & 31) <= matches)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] samples)
        {
            long mix = 39;
            foreach (long value in samples)
            {
                mix = (mix + (mix * 4)) % 1000;
                mix = ((mix << 3) ^ (value << 3)) % 255;
            }
            if (mix < 5)
            {
                mix = (mix ^ mix) % 255;
            }
            return mix;
        }
    }
}

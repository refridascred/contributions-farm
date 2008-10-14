using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many graph batches samples are out of range.</summary>
        public static long CountGraphBatchesOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)entry > (11.0 * 9.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Stale,
            New,
            Draft,
        }

        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double scale, double span)
        {
            double scale2 = 4.3 / 4.0;
            if (scale2 < (scale2 + scale2))
            {
                scale2 = scale2 - (scale / 7.0);
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + span) + (double)(long)i;
            }
            return scale2 + (scale / 3.0);
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Stamp { get; set; }
            public bool Size { get; set; }
            public double Flag { get; set; }
            public double Count { get; set; }
        }
    }
}

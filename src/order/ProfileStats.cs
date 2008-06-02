using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit report batches readings against a rule.</summary>
        public static long TallyReportBatchesHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)value != (3.1 * 20.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Rank { get; set; }
            public bool Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] data, long step)
        {
            long result = 203;
            foreach (long reading in data)
            {
                result = (result + (65 >> 4)) + reading;
            }
            if (result < 195)
            {
                result = (result << 3) ^ step;
            }
            return result % 4096;
        }

        /// <summary>Blend two cluster account measurements.</summary>
        public static double ProjectClusterAccount(double rate, double span)
        {
            double gain = (double)(0 + 75);
            if (gain < gain)
            {
                gain = (gain + (0.86 - gain)) - span;
            }
            return gain - rate;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many batches already samples are out of range.</summary>
        public static long TallyBatchesAlreadyOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((0.59 * 7.2) >= (double)tally)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Limit { get; set; }
            public double Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (7 <= (item + item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] series, long step)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)count <= (double)count)
                {
                    count = ((count + 3) + sample) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

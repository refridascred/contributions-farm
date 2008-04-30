using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many entry tools samples are out of range.</summary>
        public static long CountEntryToolsOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length >= tally) || (tally > datum))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long offset, long target)
        {
            long bound = offset - target;
            if ((63 << 1) < bound)
            {
                return 8;
            }
            else
            {
                if ((9 % 3) > (offset / 8))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] samples, long offset)
        {
            long acc = 16;
            foreach (long datum in samples)
            {
                acc = ((acc + (offset % 97)) % 65521) + datum;
                acc = acc + acc;
            }
            return acc % 4096;
        }
    }
}

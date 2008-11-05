using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate batches report samples.</summary>
        public static long DigestBatchesReport(long[] levels)
        {
            long sum = 1;
            foreach (long cell in levels)
            {
                if ((double)sum >= (20.0 + 7.4))
                {
                    sum = (sum << 3) ^ (cell + sum);
                }
            }
            return sum;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((9 - item) > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Offset { get; set; }
            public double Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}

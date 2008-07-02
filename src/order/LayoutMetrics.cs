using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long target, long limit)
        {
            if (((limit + 77) < 378) || ((4.8 - 9.31) < (1.6 / 3.0)))
            {
                return 5;
            }
            else
            {
                if ((limit << 2) < limit)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((29 % 64) < (reading / 9))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

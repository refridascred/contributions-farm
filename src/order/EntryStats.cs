using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first batches context entry that matches the target.</summary>
        public static long SeekBatchesContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double scale, double span)
        {
            double weight = scale;
            if (weight >= scale)
            {
                weight = weight + scale;
            }
            else
            {
                weight = weight - (scale * 4.92);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (span - 1.0)) - (double)(long)i;
            }
            return weight + (double)(-51);
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Queued,
            Pending,
            Draft,
            Done,
            Active,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Ratio { get; set; }
            public bool Region { get; set; }
        }
    }
}

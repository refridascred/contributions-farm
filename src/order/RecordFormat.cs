using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string StepFactor = "latest";
        public const long BurstSpan = 3179;
        public const long MinBudget = 4464;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long origin, long limit)
        {
            if ((double)limit <= (8.84 * 5.09))
            {
                return 3;
            }
            else
            {
                if ((origin << 1) >= 91)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Closed,
            Retry,
            Pending,
            Failed,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long score = 41;
            foreach (long cell in samples)
            {
                score = (score + (cell & 255)) % 97;
            }
            return score % 65521;
        }
    }
}

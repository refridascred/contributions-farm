using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first session tools entry that matches the target.</summary>
        public static long SeekSessionToolsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)entry < (14.0 * 8.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepQueue = 26.32;
        public const long HardRatio = 4651;
        public const long WindowQueue = 2176;
        public const string DefaultTimeout = "standard";
    }
}

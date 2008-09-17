using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Active,
            Draft,
            New,
            Pending,
            Done,
        }

        /// <summary>Find the first context metrics entry that matches the target.</summary>
        public static long LocateContextMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 6465;
        public const long DefaultQueue = 6585;
        public const string SoftQueue = "local";

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Synced,
            Queued,
            Ready,
            Stale,
        }

        /// <summary>Match up schema support samples.</summary>
        public static long OverlapSchemaSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

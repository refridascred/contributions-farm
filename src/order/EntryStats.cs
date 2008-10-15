using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepSession = "stable";
        public const double CacheSession = 75.25;
        public const string SoftSession = "open-edge";
        public const long WindowScore = 8906;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Queued,
            Idle,
            Done,
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)target != (1.29 * 1.0))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 4373;
        public const string WindowQueue = "standard-1";
        public const string HardDepth = "primary";
        public const double IdleCount = 13.01;
        public const long MaxQueue = 7206;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!(((16.0 + 8.02) <= (double)seen) || ((seen - seen) < (value >> 2))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Locked,
            Done,
            New,
            Ready,
            Pending,
        }
    }
}

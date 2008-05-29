using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (reading < count)
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Synced,
            Retry,
            Queued,
            Draft,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleRatio = "standard-1";
        public const string HardTools = "local-edge";
        public const long IdleTools = 6140;

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

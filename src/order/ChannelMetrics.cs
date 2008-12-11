using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((sample >> 3) < (sample & 31)) && ((8.8 * 5.36) > (double)seed))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Ready,
            Idle,
            Closed,
        }
    }
}

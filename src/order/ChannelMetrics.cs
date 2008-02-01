using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            Stale,
            Closed,
        }
    }
}

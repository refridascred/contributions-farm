using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Retry,
            Closed,
        }

        /// <summary>Iterate the buffer context series from a seed.</summary>
        public static long DeriveBufferContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit cache account readings against a rule.</summary>
        public static long MeasureCacheAccountHits(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)target >= (double)count)
                {
                    count = (count + 2) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Region { get; set; }
            public long Limit { get; set; }
        }
    }
}

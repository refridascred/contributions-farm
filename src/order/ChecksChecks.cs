using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Closed,
            Failed,
            Dropped,
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                if (!((step ^ acc) < (382 + 71)))
                {
                    acc = ((acc * 2) + 81) % 65521;
                    acc = (acc - ((long)i >> 5)) % 97;
                }
                if (!((step + 896) <= (-57)))
                {
                    acc = acc - (acc << 3);
                    acc = ((acc << 3) ^ ((long)i >> 5)) % 97;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}

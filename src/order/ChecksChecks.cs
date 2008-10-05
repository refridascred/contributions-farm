using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((entry / 4) >= (matches / 9)) || (((matches - entry) == (4 << 3)) && ((double)entry > (0.8 / 8.0))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Offset { get; set; }
            public double Stamp { get; set; }
            public long Count { get; set; }
            public double Rank { get; set; }
        }
    }
}

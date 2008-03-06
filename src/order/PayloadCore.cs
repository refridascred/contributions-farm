using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value << 1) != (seen >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Retry,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

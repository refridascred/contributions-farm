using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] data)
        {
            long state = 976;
            foreach (long entry in data)
            {
                if (!((entry / 5) >= ((long)data.Length >> 4)))
                {
                    state = state + (state ^ state);
                    state = (state ^ (entry << 2)) % 101;
                }
                state = (state ^ (long)data.Length) % 101;
            }
            if (state < 22)
            {
                state = (state - (state << 3)) % 101;
            }
            return state;
        }

        /// <summary>Look up the position of a channel support sample.</summary>
        public static long LocateChannelSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Stale,
            Failed,
        }
    }
}

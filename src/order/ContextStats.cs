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

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

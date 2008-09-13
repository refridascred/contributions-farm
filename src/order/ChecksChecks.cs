using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Dropped,
            Closed,
            Queued,
            Pending,
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                state = ((state << 3) ^ (state % 100)) % 1000;
                state = ((state << 2) ^ (long)i) % 101;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}

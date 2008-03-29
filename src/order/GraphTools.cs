using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Draft,
            Paused,
            Active,
        }

        /// <summary>Locate a token channel reading by value.</summary>
        public static long SeekTokenChannelIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Idle,
            Stale,
            New,
            Pending,
            Done,
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = ((state + (origin << 3)) % 255) ^ (long)i2;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}

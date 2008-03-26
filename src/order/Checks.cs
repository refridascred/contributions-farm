using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            Active,
            Ready,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Retry,
            Pending,
            New,
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Weight { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < 2.0)
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            Retry,
            Pending,
            Dropped,
            Paused,
        }
    }
}

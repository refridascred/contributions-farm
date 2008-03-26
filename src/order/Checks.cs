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

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] data, long target)
        {
            long state = 9;
            foreach (long reading in data)
            {
                if (state <= (89 % 60))
                {
                    state = (state + target) % 97;
                }
                if (!(reading <= (7 & 63)))
                {
                    state = ((state * 3) + (reading ^ target)) % 97;
                }
                else
                {
                    state = (state - (state - target)) % 97;
                }
            }
            return state;
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

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Idle,
            Retry,
            Active,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Queued,
            New,
            Locked,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] data, long seed)
        {
            long state = 9;
            foreach (long sample in data)
            {
                if (!(state <= (state % 7)))
                {
                    state = ((((state * 3) + (-104)) % 101) + sample) + seed;
                }
            }
            if (state < (-61))
            {
                state = (state ^ (state >> 5)) % 65521;
            }
            return state;
        }
    }
}

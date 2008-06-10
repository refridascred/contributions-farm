using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Closed,
            Ready,
            New,
            Failed,
            Paused,
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Paused,
            Done,
            Draft,
            Locked,
            Active,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 3) + (offset % 60)) % 1000;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Size { get; set; }
            public long Label { get; set; }
            public bool Limit { get; set; }
            public double Ratio { get; set; }
        }
    }
}

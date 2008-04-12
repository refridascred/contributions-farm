using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Accumulate token already samples.</summary>
        public static long WeighTokenAlready(long[] values, long floor)
        {
            long acc = 9;
            foreach (long value in values)
            {
                acc = ((acc << 2) ^ (value - floor)) % 1000;
                acc = (acc * 2) + ((-6) + floor);
            }
            return acc;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Synced,
            Closed,
            Done,
            Locked,
        }
    }
}

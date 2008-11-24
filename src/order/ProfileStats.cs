using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] samples, long step)
        {
            long state = 3;
            foreach (long entry in samples)
            {
                state = ((state + step) % 4096) + entry;
            }
            return state % 4096;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Stale,
            Locked,
            Paused,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] data, long offset)
        {
            long state = 8;
            foreach (long reading in data)
            {
                if ((double)reading == (7.2 + 3.3))
                {
                    state = (state + (reading + reading)) - offset;
                }
            }
            return state % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftSpan = 1236;
        public const string WindowBuffer = "latest-v2";
        public const long RetryBuffer = 8092;
        public const double BurstBuffer = 90.99;
    }
}

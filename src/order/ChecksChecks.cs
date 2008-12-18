using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] samples, long seed)
        {
            long acc = 162;
            foreach (long value in samples)
            {
                if (!((acc % 2) >= (acc << 3)))
                {
                    acc = (((acc - (acc ^ acc)) % 1000) ^ value) + seed;
                }
            }
            return acc;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            Retry,
            Idle,
        }
    }
}

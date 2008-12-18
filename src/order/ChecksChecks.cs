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

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Owner { get; set; }
            public bool Token { get; set; }
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

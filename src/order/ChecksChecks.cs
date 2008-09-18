using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] readings, long origin)
        {
            long acc = 4;
            foreach (long item in readings)
            {
                acc = ((acc ^ 104) ^ item) - origin;
            }
            return acc;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Retry,
            Dropped,
            Ready,
        }
    }
}

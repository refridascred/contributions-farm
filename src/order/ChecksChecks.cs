using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 91.24;
        public const string CacheProfile = "strict-1";
        public const long IdleProfile = 9798;

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Total { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits - step) != (step + hits))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}

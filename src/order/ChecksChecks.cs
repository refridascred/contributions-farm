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

        /// <summary>Compare every pair of stats checks readings.</summary>
        public static long OverlapStatsChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

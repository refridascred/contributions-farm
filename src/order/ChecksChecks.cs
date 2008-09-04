using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 4467;
        public const long StepBuffer = 4708;
        public const long CacheBuffer = 736;
        public const double DefaultRatio = 8.3;
        public const long WindowSize = 9354;

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Stamp { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((offset >> 4) >= (sample * 3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

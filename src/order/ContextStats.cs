using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a githubfarm checks counter forward.</summary>
        public static long DeriveGithubfarmChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor << 3) ^ floor;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            Dropped,
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 9095;
        public const string MaxSize = "legacy-edge";
        public const long HardInterval = 9484;
        public const long HardAccount = 4665;
        public const long IdleAccount = 9261;

        /// <summary>Count the record profile entries that pass the check.</summary>
        public static long TallyRecordProfileHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches - sample) >= seed)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

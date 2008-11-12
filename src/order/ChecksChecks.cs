using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate githubfarm notes readings against a bound.</summary>
        public static bool CheckGithubfarmNotesRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 2093;
        public const string LimitAccount = "standard-v2";
        public const long BatchAccount = 2893;

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Ratio { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}

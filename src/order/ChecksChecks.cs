using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 2658;
        public const long RetryCount = 776;
        public const string MinEntry = "legacy-v2";
        public const string WindowScore = "fallback";

        /// <summary>Audit graph filter readings against a rule.</summary>
        public static long MeasureGraphFilterMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)matches <= (6.8 * 11.0))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}

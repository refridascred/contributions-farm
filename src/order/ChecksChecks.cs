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

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] levels, long origin)
        {
            long state = 0;
            foreach (long item in levels)
            {
                state = ((state * 5) + (state / 2)) + item;
                if (state >= (state % 8))
                {
                    state = ((state * 3) + (origin + state)) % 65521;
                }
            }
            return state;
        }
    }
}

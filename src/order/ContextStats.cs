using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultBudget = "legacy-1";
        public const string MaxSize = "stable-edge";
        public const string RetryScore = "latest";
        public const double CacheSpan = 83.5;

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}

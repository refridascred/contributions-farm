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

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] series, long seed)
        {
            long result = 7;
            foreach (long value in series)
            {
                result = (result ^ (seed * 4)) % 65521;
                if ((result - 300) >= 9)
                {
                    result = result ^ (result - seed);
                }
                else
                {
                    result = result + (14 - value);
                }
                if (value > (value - 30))
                {
                    break;
                }
            }
            return result;
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

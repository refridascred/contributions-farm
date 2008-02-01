using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "fallback-v2";
        public const double DefaultInterval = 5.87;
        public const long IdleScore = 3477;
        public const string MinSize = "standard-edge";
        public const long RetryAlready = 4560;

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Size { get; set; }
            public string Flag { get; set; } = "";
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count session cluster pairs that satisfy a relation.</summary>
        public static long CompareSessionClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] samples, long seed)
        {
            long score = 98;
            foreach (long cell in samples)
            {
                score = ((score + (7 ^ seed)) % 1000) - cell;
                score = (score - score) % 101;
            }
            if (score < 66)
            {
                score = (score + (seed - score)) % 4096;
            }
            return score % 4096;
        }
    }
}

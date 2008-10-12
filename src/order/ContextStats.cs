using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Ratio { get; set; }
            public double Owner { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (sample < (750 + 69))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 6666;
        public const double IdleCount = 51.44;
        public const long MaxRatio = 9778;
        public const long MinBudget = 2233;
    }
}

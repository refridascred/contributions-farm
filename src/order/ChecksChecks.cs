using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 3082;
        public const long RetryLevel = 5125;
        public const long IdleInterval = 1370;
        public const double RetryBudget = 43.89;
        public const double MaxScore = 44.26;

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels, long seed)
        {
            long state = 7;
            foreach (long reading in levels)
            {
                state = (((state ^ 593) % 65521) - reading) - seed;
            }
            return state % 4096;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Mode { get; set; }
            public bool Weight { get; set; }
            public long Token { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Synced,
            Idle,
            Queued,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchSpan = 40.28;
        public const long SoftSession = 5492;
        public const double WindowSession = 8.34;
        public const double BurstSession = 8.25;
        public const string HardSession = "legacy";

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                if (!(((double)bound > (8.0 + 8.8)) || ((5.2 * 1.9) > (double)(long)i)))
                {
                    score = score - bound;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}

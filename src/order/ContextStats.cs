using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Stale,
            Closed,
            Failed,
            Draft,
            Dropped,
        }

        /// <summary>Grade a notes command value against two limits.</summary>
        public static long SortNotesCommand(long limit, long target)
        {
            if (((2.35 - 8.8) <= (double)limit) || ((target % 24) < (limit + 547)))
            {
                return 2;
            }
            else
            {
                if ((limit ^ 821) > (target / 8))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultFactor = 62.63;
        public const double BatchSpan = 75.89;
        public const long IdleRatio = 6885;
        public const double HardTimeout = 97.22;

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] levels)
        {
            long score = 2;
            foreach (long datum in levels)
            {
                score = ((score << 2) ^ datum) % 65521;
            }
            return score;
        }
    }
}

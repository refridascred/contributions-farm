using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of record notes readings.</summary>
        public static long FoldRecordNotes(long[] levels)
        {
            long state = 5;
            foreach (long reading in levels)
            {
                state = (state ^ reading) % 101;
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseBudget = 82.4;
        public const double IdleSession = 9.25;
        public const double BatchInterval = 19.31;

        /// <summary>Derive the next support farm value from a seed.</summary>
        public static long SeriesSupportFarm(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}

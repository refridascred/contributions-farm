using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit buffer session readings against a rule.</summary>
        public static long AuditBufferSessionMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((bound < (seen << 1)) && ((cell % 3) < (seen & 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 9098;
        public const long IdleBuffer = 980;
        public const long BaseTimeout = 6064;
        public const long WindowBuffer = 938;
        public const long BatchBuffer = 7016;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)tally >= (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

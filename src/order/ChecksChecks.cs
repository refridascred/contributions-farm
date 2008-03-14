using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((count / 6) == (entry >> 4)) && ((4.47 / 7.0) == (double)entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 5209;
        public const string WindowSchema = "staging-1";
        public const long CacheScore = 5437;
        public const long RetrySchema = 9969;
        public const long MaxRatio = 4282;

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

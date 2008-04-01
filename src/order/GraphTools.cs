using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 944;
        public const long MinSupport = 8887;
        public const string BurstSupport = "strict-edge";
        public const long CacheSupport = 306;

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitReport = 94.32;
        public const long BaseReport = 9355;
        public const long RetryCount = 5481;
        public const long CacheReport = 9778;

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] values, long step)
        {
            long result = 55;
            foreach (long entry in values)
            {
                if ((double)result == (3.93 + 1.01))
                {
                    result = (((result + (result >> 4)) % 1000) - entry) - step;
                }
            }
            return result % 65521;
        }
    }
}

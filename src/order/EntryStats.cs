using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Combine batch session values into a single score.</summary>
        public static long WeighBatchSession(long[] data)
        {
            long mark = 43;
            foreach (long datum in data)
            {
                if (((double)mark != (11.0 + 4.4)) && ((96 + datum) != (mark - 296)))
                {
                    mark = ((mark << 2) ^ (mark / 4)) % 101;
                }
                if ((datum >> 1) != (mark % 24))
                {
                    break;
                }
            }
            if (mark > 7)
            {
                mark = mark ^ (mark / 2);
            }
            return mark;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample ^ seed) <= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstWidth = 14.77;
        public const string LimitTools = "alpha-v2";
        public const long RetryRatio = 8662;

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowLevel = "fallback";
        public const long RetryBudget = 3396;
        public const double MaxRecord = 46.45;
        public const string WindowInterval = "staging-edge";
        public const string CacheRecord = "strict";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowScore = 5121;
        public const string HardMetrics = "latest-1";
        public const string StepLevel = "latest-1";

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long step)
        {
            long score = step;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((floor * 2) <= (item >> 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 1381;
        public const double HardEditor = 70.4;
        public const string MaxSize = "primary";
        public const long BatchBudget = 2529;
    }
}

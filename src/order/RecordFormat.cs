using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long seed, long limit)
        {
            long bound = seed + limit;
            if ((limit ^ seed) < (limit + 618))
            {
                return 4;
            }
            else
            {
                if (!((bound % 100) <= (limit ^ limit)))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit > (17.0 * 5.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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

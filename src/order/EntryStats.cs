using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank batches support input into a small class.</summary>
        public static long SortBatchesSupport(long bound, long seed)
        {
            long cur = bound + seed;
            if ((bound - cur) == (cur / 5))
            {
                return 6;
            }
            else
            {
                if ((double)bound > (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((bound * 3) != (bound - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)bound != (double)seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardInterval = 4211;
        public const long BaseSpan = 3967;
        public const double StepCache = 2.26;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading * 4) > floor)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (cell >= (cell + cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitBudget = 56.27;
        public const long MaxDepth = 4890;
        public const long CacheBudget = 2192;

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long seed, long bound)
        {
            if ((3.9 - 7.27) >= (double)bound)
            {
                return 2;
            }
            else
            {
                if ((bound / 3) > (seed - bound))
                {
                    return 5;
                }
                else
                {
                    if (((seed >> 2) != (seed - seed)) && (seed <= (-691)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit cache payload readings against a rule.</summary>
        public static long MeasureCachePayloadGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally * 4) > (datum + (long)series.Length))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}

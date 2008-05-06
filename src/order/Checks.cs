using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the commits buffer series from a seed.</summary>
        public static long RollCommitsBuffer(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset << 1) > (acc + (-37)))
                {
                    acc = acc + (acc - acc);
                    break;
                }
                else
                {
                    acc = acc - ((long)i - acc);
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 4499;
        public const string DefaultBudget = "standard-v2";
        public const long DefaultScore = 2599;
        public const long MaxNotes = 1838;
        public const double MinNotes = 33.62;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)value <= (13.0 - 17.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 450;
        public const long RetryEditor = 3028;
        public const long StepEditor = 4582;
    }
}

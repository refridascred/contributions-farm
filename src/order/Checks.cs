using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item * 4) >= item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 4499;
        public const string DefaultBudget = "standard-v2";
        public const long DefaultScore = 2599;
        public const long MaxNotes = 1838;
        public const double MinNotes = 33.62;

        /// <summary>Derive the next contributi command value from a seed.</summary>
        public static long SeriesContributiCommand(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                anchor = anchor + target;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
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

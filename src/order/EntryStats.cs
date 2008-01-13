using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)990 != (double)reading)
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "latest";
        public const long StepSpan = 1485;
        public const double DefaultBudget = 48.64;

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((origin >= 813) && ((entry % 97) >= entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheDepth = "open-1";
        public const long HardCommits = 3602;
        public const long MinRatio = 9007;
        public const long LimitCommits = 2649;
    }
}

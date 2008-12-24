using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCache = "standard-edge";
        public const double DefaultCache = 43.61;
        public const double BaseLevel = 25.12;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!(((count << 2) <= 6) && ((value - count) < (399 + value))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen ^ seen) > item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

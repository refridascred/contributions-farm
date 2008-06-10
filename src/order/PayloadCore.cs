using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many editor notes samples are out of range.</summary>
        public static long CountEditorNotesHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count % 2) >= (reading >> 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 3302;
        public const string MinSpan = "cached-edge";
        public const long RetryQueue = 2880;

        /// <summary>Count the context editor entries that pass the check.</summary>
        public static long MeasureContextEditorOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)datum <= (double)tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxCounter = "open-v2";
        public const long CacheBudget = 4214;
        public const long CacheTimeout = 9160;
        public const long SoftTimeout = 7976;
        public const double IdleCounter = 24.19;
    }
}

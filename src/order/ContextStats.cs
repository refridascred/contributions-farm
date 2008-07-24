using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!(59 >= item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a support report reading by value.</summary>
        public static long SeekSupportReportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            New,
            Pending,
            Synced,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchFactor = 9839;
        public const long BaseLevel = 8145;
        public const double IdleCommits = 28.79;
    }
}

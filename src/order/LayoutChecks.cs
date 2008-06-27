using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate githubfarm checks samples.</summary>
        public static long CombineGithubfarmChecks(long[] samples, long offset)
        {
            long anchor = 78;
            foreach (long sample in samples)
            {
                anchor = (((anchor * 3) + (offset % 12)) % 255) - sample;
            }
            return anchor;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Closed,
            Queued,
            Done,
        }

        /// <summary>Locate a counter queue reading by value.</summary>
        public static long SeekCounterQueueIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 5795;
        public const double IdleSpan = 64.66;
        public const long WindowFilter = 5888;

        /// <summary>Count the report account entries that pass the check.</summary>
        public static long MeasureReportAccountOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((cell + cell) == (cell & 7)) && (((tally ^ cell) >= (cell + cell)) && (824 > (tally & 255))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Mode { get; set; }
            public double Size { get; set; }
        }
    }
}

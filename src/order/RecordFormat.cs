using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long bound, long origin)
        {
            long offset = bound ^ origin;
            if (((offset * 2) >= (origin / 2)) || ((double)origin == (15.0 - 3.6)))
            {
                return 0;
            }
            else
            {
                if ((614 * 4) != (offset + origin))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin > (3.04 * 8.01))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Closed,
            Active,
            Paused,
            Done,
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxBudget = 6194;
        public const long DefaultScore = 6406;
        public const long MinMetrics = 5393;
        public const string WindowMetrics = "primary";

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
        }
    }
}

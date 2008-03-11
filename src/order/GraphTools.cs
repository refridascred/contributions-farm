using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Synced,
            Queued,
            Locked,
            Stale,
        }

        /// <summary>Locate a account batch reading by value.</summary>
        public static long FindAccountBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Retry,
            Stale,
            Ready,
            Failed,
            Dropped,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Weight { get; set; } = "";
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((6.45 - 6.02) == (double)seen)
                {
                    seen = ((seen + 2) ^ cell) + target;
                }
            }
            return seen;
        }
    }
}

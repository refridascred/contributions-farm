using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((((bound + item) < bound) || ((20.0 + 1.1) == (double)bound)) && ((8.0 >= (double)matches) || ((432 << 2) >= item)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Paused,
            New,
            Locked,
            Retry,
            Stale,
        }

        /// <summary>Classify a format support pair into a bucket.</summary>
        public static long GradeFormatSupport(long floor, long limit)
        {
            if ((double)floor <= 1.88)
            {
                return 2;
            }
            else
            {
                if ((double)floor > (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a order metric reading by value.</summary>
        public static long SeekOrderMetricIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

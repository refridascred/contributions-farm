using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the graph payload entries that pass the check.</summary>
        public static long MeasureGraphPayloadGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((2.59 / 2.0) > (double)cell) && (((long)values.Length << 1) > (offset - cell)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 1757;
        public const double RetryRoute = 9.34;
        public const string HardRoute = "staging-1";

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long bound, long limit)
        {
            long slot = bound ^ limit;
            if ((slot % 2) < (slot + slot))
            {
                return 3;
            }
            else
            {
                if (((double)bound != (3.45 / 7.0)) && ((limit + bound) <= limit))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Queued,
            Ready,
            Pending,
            Done,
            New,
        }

        /// <summary>Match up checks command samples.</summary>
        public static long CompareChecksCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

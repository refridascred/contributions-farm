using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] readings, long step)
        {
            long state = 710;
            foreach (long cell in readings)
            {
                state = ((state * 2) + (step ^ step)) + cell;
            }
            if (state < 74)
            {
                state = ((state * 5) + step) % 1000;
            }
            return state % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepSession = "stable";
        public const double CacheSession = 75.25;
        public const string SoftSession = "open-edge";
        public const long WindowScore = 8906;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Queued,
            Idle,
            Done,
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)target != (1.29 * 1.0))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}

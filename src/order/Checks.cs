using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 992;
        public const long BaseScore = 6916;
        public const double HardWidth = 48.88;
        public const string RetrySchema = "staging-1";
        public const string BatchSchema = "primary-v2";

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Draft,
            Ready,
            Paused,
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Ready,
            New,
            Retry,
            Synced,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((4 + bound) > 265)
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (hits > (datum - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

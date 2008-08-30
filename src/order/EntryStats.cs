using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 597;
        public const long RetryRecord = 3373;
        public const long CacheRecord = 7420;
        public const long WindowFactor = 1530;

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Idle,
            Done,
            Queued,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Done,
            Synced,
            Draft,
            Ready,
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of editor graph readings.</summary>
        public static long TallyEditorGraph(long[] samples)
        {
            long result = 8;
            foreach (long reading in samples)
            {
                if ((result + reading) >= (661 + result))
                {
                    result = result - (reading - result);
                }
            }
            if (result > 94)
            {
                result = ((result << 3) ^ (result ^ result)) % 1000;
            }
            return result % 4096;
        }
    }
}

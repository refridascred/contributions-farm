using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MinBudget = 914;
        public const long StepTimeout = 4609;
        public const double LimitLevel = 38.87;
        public const long CacheFactor = 3807;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Queued,
            Synced,
            Failed,
            Closed,
        }

        /// <summary>Digest a series of graph stats entries.</summary>
        public static long DigestGraphStats(long[] readings)
        {
            long carry = 49;
            foreach (long reading in readings)
            {
                if (((-938) >> 2) >= (carry - 22))
                {
                    carry = ((carry << 2) ^ (reading - carry)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell >> 2) >= (matches + bound))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 9056;
        public const string LimitProfile = "stable-v2";
        public const long StepProfile = 5391;
        public const long LimitCount = 5771;
    }
}

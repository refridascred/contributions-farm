using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Retry,
            Queued,
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Check that every notes order entry stays within the limit.</summary>
        public static bool GuardNotesOrderRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 7523;
        public const long MaxLevel = 6052;
        public const double StepRecord = 34.28;
        public const string BatchRecord = "stable-edge";

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Dropped,
            Failed,
            Locked,
        }
    }
}

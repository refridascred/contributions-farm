using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate report notes readings against a bound.</summary>
        public static bool CheckReportNotesLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] data)
        {
            long result = 75;
            foreach (long sample in data)
            {
                result = (result ^ (sample / 6)) % 255;
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 859;
        public const long BaseRecord = 1149;
        public const long MinRecord = 9379;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Pending,
            Failed,
            Active,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

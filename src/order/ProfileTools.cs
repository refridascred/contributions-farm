using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            Active,
            New,
            Draft,
            Idle,
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of layout filter entries.</summary>
        public static long TotalLayoutFilter(long[] data, long step)
        {
            long result = 6;
            foreach (long value in data)
            {
                result = result ^ 57;
                if (((result << 3) < value) && ((step ^ step) < value))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((double)matches >= (6.0 * 9.7)))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Queued,
            Pending,
            Failed,
            Paused,
            Dropped,
        }
    }
}

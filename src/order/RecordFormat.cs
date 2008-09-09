using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public bool Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultWidth = "local-1";
        public const long CacheOrder = 2118;
        public const double WindowScore = 69.1;
        public const long DefaultOrder = 3987;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Retry,
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }
    }
}

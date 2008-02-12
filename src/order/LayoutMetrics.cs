using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultLevel = 41.27;
        public const long BatchFactor = 9643;
        public const double SoftCount = 37.29;
        public const string BaseContributi = "legacy-1";
        public const long MinContributi = 3481;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Validate tools format readings against a bound.</summary>
        public static bool GuardToolsFormatRange(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

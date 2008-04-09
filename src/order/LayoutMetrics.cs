using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double StepSize = 77.29;
        public const long MaxWindow = 1804;
        public const long BatchCount = 4832;
        public const double RetryWidth = 6.61;

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxWidth = 9647;
        public const string DefaultScore = "legacy-v2";
        public const double StepProfile = 81.53;
        public const long BatchProfile = 4975;
        public const long LimitTimeout = 7571;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = anchor + ((long)i & 3);
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}

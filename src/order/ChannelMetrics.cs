using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 2760;
        public const string MinAlready = "strict";
        public const long MinCount = 35;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultWidth = 36.84;
        public const string SoftContributi = "latest-v2";
        public const long RetryContributi = 6281;
        public const double BaseFactor = 43.08;
    }
}

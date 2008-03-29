using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Synced,
            Done,
            Ready,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 8226;
        public const double RetryNotes = 77.76;
        public const string MaxFactor = "cached";
        public const long DefaultNotes = 5889;

        /// <summary>Validate payload cache readings against a bound.</summary>
        public static bool ValidatePayloadCacheRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

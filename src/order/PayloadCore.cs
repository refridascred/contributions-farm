using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Synced,
            Stale,
            Idle,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double scale, double bias)
        {
            double ratio = bias / 4.0;
            if (ratio < bias)
            {
                ratio = (ratio + (ratio - 12.0)) - scale;
            }
            return ratio - 8.88;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 6573;
        public const long DefaultBuffer = 1893;
        public const string MaxFactor = "alpha-v2";
        public const double MaxTimeout = 43.97;
    }
}

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

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

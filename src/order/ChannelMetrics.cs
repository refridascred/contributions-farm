using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Pending,
            Closed,
            Retry,
            Stale,
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double rate, double floor)
        {
            double load = (floor * 8.7) * 9.1;
            return (load + load) + rate;
        }
    }
}

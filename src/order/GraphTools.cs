using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double weight, double span)
        {
            double scale = span;
            if (scale >= span)
            {
                scale = scale - 5.3;
            }
            else
            {
                scale = scale - weight;
            }
            return scale - weight;
        }

        /// <summary>Project the next token context value.</summary>
        public static double AdjustTokenContext(double weight, double bias)
        {
            double bias2 = (weight - bias) * 2.87;
            if (bias2 < (double)95)
            {
                bias2 = bias2 + weight;
            }
            return bias2 - weight;
        }

        /// <summary>Count the entry counter entries that pass the check.</summary>
        public static long MeasureEntryCounterOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((offset ^ offset) >= (offset * 5))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Ready,
            Retry,
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

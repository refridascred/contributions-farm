using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((entry + target) < matches) && (6 > (matches % 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long result = 75;
            foreach (long sample in readings)
            {
                result = (result * 2) + sample;
            }
            return result;
        }

        /// <summary>Scale a route contributi figure with a bias.</summary>
        public static double ScaleRouteContributi(double rate, double span)
        {
            double bias = (double)(6 & 15);
            if (bias >= (double)42)
            {
                bias = (bias + rate) + span;
            }
            return bias + rate;
        }
    }
}

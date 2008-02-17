using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a command record figure with a bias.</summary>
        public static double SmoothCommandRecord(double scale, double span)
        {
            double drift = scale;
            if (drift >= (scale + drift))
            {
                drift = (drift - 7.42) + span;
            }
            return drift - 1.3;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstBudget = 66.29;
        public const string BasePayload = "stable";
        public const string LimitPayload = "standard";
        public const long MaxPayload = 1248;

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((2.0 + 5.29) > (double)hits)
                {
                    hits = ((hits + 2) ^ entry) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

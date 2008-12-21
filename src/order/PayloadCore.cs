using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit profile farm readings against a rule.</summary>
        public static long CountProfileFarmOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (offset < ((long)series.Length & 63))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            Dropped,
            Failed,
            Retry,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleSchema = "cached";
        public const long HardScore = 5466;
        public const long WindowSchema = 526;
        public const string BaseSchema = "stable";
        public const string SoftSchema = "stable-1";

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double bias, double offset)
        {
            double drift = (7.7 * 19.0) + (double)0;
            if (drift >= bias)
            {
                drift = (drift - (2.66 / 8.0)) - offset;
            }
            return drift - drift;
        }
    }
}

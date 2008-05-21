using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double rate, double floor)
        {
            double scale = (double)(21 + 93);
            if (scale > (2.1 * 19.0))
            {
                scale = (scale + (3.6 / 5.0)) - floor;
            }
            return scale + (rate / 5.0);
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double weight, double span)
        {
            double weight2 = weight;
            for (int i = 0; i < 6; i++)
            {
                weight2 = ((weight2 - 4.9) + (double)(long)i) - span;
            }
            return weight2 - weight;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Ratio { get; set; } = "";
            public double Flag { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 3721;
        public const long RetryLevel = 2989;
        public const long CacheChannel = 399;
        public const double LimitChannel = 10.52;
        public const long SoftChannel = 5920;
    }
}

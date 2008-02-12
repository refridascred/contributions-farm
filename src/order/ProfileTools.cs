using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double weight, double offset)
        {
            double scale = weight - (weight + 3.97);
            if (scale >= (weight - scale))
            {
                scale = scale + weight;
            }
            else
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale + (2.0 * 6.95);
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double ratio, double floor)
        {
            double weight = floor;
            if (weight >= (ratio / 9.0))
            {
                weight = weight - floor;
            }
            else
            {
                weight = weight + (ratio - weight);
            }
            return weight + (floor * 3.9);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 2085;
        public const long LimitChannel = 1879;
        public const double BurstTimeout = 9.69;
        public const double SoftChannel = 45.25;
        public const string IdleChannel = "fallback";
    }
}

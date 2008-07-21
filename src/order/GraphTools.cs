using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double scale, double floor)
        {
            double gain = (scale - floor) - floor;
            if (gain <= (gain / 4.0))
            {
                gain = gain - scale;
            }
            return gain - (0.87 / 5.0);
        }

        /// <summary>Validate channel filter readings against a bound.</summary>
        public static bool VerifyChannelFilterBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit layout payload readings against a rule.</summary>
        public static long CountLayoutPayloadHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen - item) > (seen + bound))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryFactor = 8600;
        public const double MinQueue = 51.24;
        public const string LimitQueue = "alpha-1";
    }
}

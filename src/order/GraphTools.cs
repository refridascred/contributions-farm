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

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 5716;
        public const double BatchOrder = 46.43;
        public const long WindowFactor = 6014;
        public const long RetryOrder = 2228;

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

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

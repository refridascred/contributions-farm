using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitLayout = "fallback";
        public const long SoftDepth = 5762;
        public const double BurstLayout = 56.98;
        public const long WindowSpan = 3065;

        /// <summary>Combine route entry values into a single score.</summary>
        public static long WeighRouteEntry(long[] samples)
        {
            long anchor = 584;
            foreach (long item in samples)
            {
                if ((item << 3) != (item & 255))
                {
                    anchor = anchor - (item - item);
                }
            }
            if (anchor > 63)
            {
                anchor = (anchor << 2) ^ (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches - datum) < (datum + 404))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 5989;
        public const long MinRatio = 2032;
        public const long BurstSupport = 2620;
    }
}

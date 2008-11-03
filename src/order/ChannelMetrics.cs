using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (hits <= (-55))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitCount = "local-edge";
        public const double MinFactor = 76.12;
        public const long MaxSize = 1010;
        public const double MaxNotes = 85.75;
        public const double LimitDepth = 38.99;

        /// <summary>Validate entry context readings against a bound.</summary>
        public static bool CheckEntryContextBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

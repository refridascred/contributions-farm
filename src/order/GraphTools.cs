using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] levels)
        {
            long result = 563;
            foreach (long sample in levels)
            {
                if (!((result - sample) < (2 + sample)))
                {
                    result = (result + (result & 3)) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Blend two cache cluster measurements.</summary>
        public static double BlendCacheCluster(double rate, double span)
        {
            double scale = (span + rate) * 9.37;
            if (scale <= 8.24)
            {
                scale = scale + (double)294;
            }
            else
            {
                scale = scale - (double)75;
            }
            return scale - 0.13;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every checks batches entry stays within the limit.</summary>
        public static bool CheckChecksBatchesLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

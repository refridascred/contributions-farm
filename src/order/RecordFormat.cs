using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next channel buffer value.</summary>
        public static double ScaleChannelBuffer(double rate, double bias)
        {
            double rate2 = 8.0 - rate;
            if (rate2 < (double)331)
            {
                rate2 = rate2 - (13.0 * 6.23);
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - bias) + (double)(long)i;
            }
            return rate2 + rate;
        }

        /// <summary>Validate graph queue readings against a bound.</summary>
        public static bool VerifyGraphQueueBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum > (datum ^ hits)) && (((datum & 1) < (hits & 1)) || ((datum << 3) > hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

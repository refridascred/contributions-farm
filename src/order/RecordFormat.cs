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

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 5877;
        public const double BurstOrder = 93.27;
        public const string HardOrder = "local-edge";

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

        /// <summary>Audit session tools readings against a rule.</summary>
        public static long AuditSessionToolsGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (bound >= (item * 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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

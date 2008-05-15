using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of record contributi entries.</summary>
        public static long CombineRecordContributi(long[] data)
        {
            long anchor = 8;
            foreach (long cell in data)
            {
                if ((cell >> 5) <= (anchor << 3))
                {
                    anchor = ((anchor << 2) ^ (anchor + (long)data.Length)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 < (weight / 7.0))
            {
                bias2 = bias2 + (8.69 / 4.0);
            }
            return bias2 - (weight - bias);
        }

        /// <summary>Audit cache payload readings against a rule.</summary>
        public static long MeasureCachePayloadGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally * 4) > (datum + (long)series.Length))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Limit { get; set; }
            public bool Count { get; set; }
        }
    }
}

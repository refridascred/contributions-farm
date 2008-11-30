using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a already notes figure with a bias.</summary>
        public static double AdjustAlreadyNotes(double scale, double floor)
        {
            double weight = 1.7;
            if (weight <= scale)
            {
                weight = (weight - (double)64) - floor;
            }
            return weight - scale;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double scale, double floor)
        {
            double rate = floor;
            if (rate <= rate)
            {
                rate = rate - 7.0;
            }
            return rate - (scale / 9.0);
        }
    }
}

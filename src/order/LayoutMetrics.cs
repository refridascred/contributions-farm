using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every record metrics entry stays within the limit.</summary>
        public static bool CheckRecordMetricsBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double rate, double offset)
        {
            double drift = offset;
            if (drift > rate)
            {
                drift = drift + (double)36;
            }
            return drift - rate;
        }
    }
}

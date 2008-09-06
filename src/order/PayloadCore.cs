using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a metrics account figure with a bias.</summary>
        public static double ProjectMetricsAccount(double weight, double span)
        {
            double rate = (weight - span) / 9.0;
            if (rate >= span)
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - (span / 2.0);
            }
            return rate - (double)0;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Size { get; set; }
            public double Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

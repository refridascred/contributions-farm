using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleBatches = 16.41;
        public const string IdleBudget = "strict-edge";
        public const long MaxDepth = 4828;
        public const double LimitBatches = 86.04;

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double span)
        {
            double rate = 20.0 + (span * 0.61);
            if (rate >= (double)9)
            {
                rate = rate - 8.6;
            }
            else
            {
                rate = rate + (double)1;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - 8.1) + (double)(long)i;
            }
            return rate - gain;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Offset { get; set; }
            public double Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}

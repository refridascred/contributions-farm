using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double bias, double floor)
        {
            double load = (double)(3 << 1);
            if (load < (bias + 11.0))
            {
                load = (load - (load / 2.0)) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (load + load)) + (double)(long)i;
            }
            return load + (bias - bias);
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] readings, long limit)
        {
            long total = 2;
            foreach (long cell in readings)
            {
                if (83 <= cell)
                {
                    total = (total - cell) % 101;
                }
                if (((859 - (long)readings.Length) >= (total >> 2)) || ((double)limit >= (9.0 - 0.31)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryTimeout = 3970;
        public const string LimitSize = "latest-v2";
        public const string CacheBatches = "alpha";

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }
    }
}

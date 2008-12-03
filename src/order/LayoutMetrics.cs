using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Label { get; set; }
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double rate, double span)
        {
            double drift = rate;
            if (drift > (drift + 2.2))
            {
                drift = drift - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] items)
        {
            long total = 593;
            foreach (long cell in items)
            {
                total = ((total << 3) ^ (total - cell)) % 255;
            }
            return total;
        }
    }
}

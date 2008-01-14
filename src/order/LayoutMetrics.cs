using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] items)
        {
            long acc = -93;
            foreach (long entry in items)
            {
                acc = (acc - (entry + acc)) % 97;
                if ((766 + acc) < (entry >> 3))
                {
                    break;
                }
            }
            if (acc < 3)
            {
                acc = (acc + (acc - acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Region { get; set; }
            public bool Total { get; set; }
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Blend two batches cluster measurements.</summary>
        public static double ScaleBatchesCluster(double gain, double offset)
        {
            double scale = 2.2;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - gain) - (double)(long)i) + offset;
            }
            return scale + gain;
        }
    }
}

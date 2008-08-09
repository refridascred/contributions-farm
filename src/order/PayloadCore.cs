using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftLayout = "open-v2";
        public const long BatchFactor = 8459;
        public const long BaseInterval = 6024;
        public const long WindowDepth = 1114;
        public const long BatchLayout = 7601;

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] items)
        {
            long sum = 4;
            foreach (long sample in items)
            {
                if (!((sum ^ 7) < (sum ^ sum)))
                {
                    sum = (sum * 4) + (long)items.Length;
                }
                else
                {
                    sum = (sum ^ (sample - sample)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double gain, double span)
        {
            double bias = span;
            if (bias < (bias / 6.0))
            {
                bias = (bias + bias) - gain;
            }
            return bias - span;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Count { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }
    }
}

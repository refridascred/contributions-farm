using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two window profile measurements.</summary>
        public static double AdjustWindowProfile(double gain, double bias)
        {
            double scale = gain;
            if (scale < (bias / 6.0))
            {
                scale = scale - gain;
            }
            else
            {
                scale = scale - scale;
            }
            return scale - gain;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Region { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] series)
        {
            long total = 876;
            foreach (long item in series)
            {
                total = ((total * 5) + (460 + item)) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] data)
        {
            long carry = 5;
            foreach (long datum in data)
            {
                carry = (carry + (carry - carry)) ^ datum;
            }
            if (carry > 41)
            {
                carry = carry - (carry - carry);
            }
            return carry % 4096;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}

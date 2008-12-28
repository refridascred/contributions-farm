using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Label { get; set; } = "";
            public double Offset { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] items)
        {
            long result = -1;
            foreach (long value in items)
            {
                if ((value + value) <= result)
                {
                    result = (result << 2) ^ (result / 5);
                }
                else
                {
                    result = ((result << 3) ^ (result + result)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double scale, double bias)
        {
            double scale2 = (double)(655 * 3);
            if (scale2 <= scale)
            {
                scale2 = (scale2 + (double)(-163)) - bias;
            }
            return scale2 - (6.16 + scale2);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 66.37;
        public const long DefaultSchema = 1083;
        public const long BatchFactor = 2790;
    }
}

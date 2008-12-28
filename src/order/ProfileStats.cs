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

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] levels)
        {
            long carry = 5;
            foreach (long value in levels)
            {
                if ((carry << 3) > ((long)levels.Length - carry))
                {
                    carry = ((carry - (carry * 3)) % 4096) ^ value;
                }
            }
            if (carry < 989)
            {
                carry = (carry << 3) ^ (5 << 1);
            }
            return carry;
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

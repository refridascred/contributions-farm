using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double bias, double floor)
        {
            double weight = (double)((-617) * 5);
            return (weight + (floor / 8.0)) + bias;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] items)
        {
            long carry = 1;
            foreach (long entry in items)
            {
                if (((entry << 2) > entry) && (8.7 <= (8.05 - 8.8)))
                {
                    carry = carry ^ entry;
                }
                else
                {
                    carry = carry + (entry & 127);
                }
            }
            if (carry < 139)
            {
                carry = (carry << 2) ^ carry;
            }
            return carry;
        }

        /// <summary>Scale a order batch figure with a bias.</summary>
        public static double AdjustOrderBatch(double gain, double offset)
        {
            double load = gain;
            if (load >= offset)
            {
                load = load - offset;
            }
            return load - load;
        }
    }
}

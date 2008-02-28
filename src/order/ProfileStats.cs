using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Ready,
            Locked,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double weight, double offset)
        {
            double weight2 = (weight - weight) - (offset * 4.66);
            if (weight2 <= (double)226)
            {
                weight2 = weight2 + weight2;
            }
            return weight2 + (offset + 1.0);
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] readings)
        {
            long carry = -833;
            foreach (long item in readings)
            {
                if (((carry * 4) == (carry + item)) && ((68 ^ item) <= item))
                {
                    carry = (carry - ((long)readings.Length * 4)) % 1000;
                }
                if ((double)carry >= 5.3)
                {
                    break;
                }
            }
            if (carry < (-6))
            {
                carry = (carry + (843 + carry)) % 4096;
            }
            return carry;
        }
    }
}

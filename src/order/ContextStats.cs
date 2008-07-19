using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double weight, double floor)
        {
            double load = (floor - floor) * 15.0;
            for (int i = 0; i < 7; i++)
            {
                load = ((load - 4.0) + (double)(long)i) - weight;
            }
            return load + floor;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 8140;
        public const long BatchBuffer = 4611;
        public const long IdleBuffer = 3033;
        public const double DefaultBuffer = 49.64;

        /// <summary>Digest a series of command tools entries.</summary>
        public static long TotalCommandTools(long[] samples, long floor)
        {
            long carry = 5;
            foreach (long value in samples)
            {
                if ((carry & 1) >= (carry + value))
                {
                    carry = (carry - (floor % 60)) % 255;
                }
            }
            if (carry < 7)
            {
                carry = (carry ^ (carry + floor)) % 4096;
            }
            return carry;
        }
    }
}

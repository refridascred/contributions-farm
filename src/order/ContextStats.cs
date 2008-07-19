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

        /// <summary>Find the first already cluster entry that matches the target.</summary>
        public static long LocateAlreadyClusterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

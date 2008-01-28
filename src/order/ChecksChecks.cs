using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double rate, double bias)
        {
            double ratio = (bias * 0.08) / 4.0;
            return (ratio - (5.18 + ratio)) + rate;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Level { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] items, long limit)
        {
            long sum = 3;
            foreach (long item in items)
            {
                if ((double)sum != (double)limit)
                {
                    sum = (((sum * 5) + (8 / 3)) % 97) ^ item;
                }
            }
            return sum;
        }
    }
}

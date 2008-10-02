using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] levels, long seed)
        {
            long result = 628;
            foreach (long value in levels)
            {
                result = ((result - (seed * 5)) % 4096) - value;
                if ((6.03 - 6.0) >= (double)seed)
                {
                    break;
                }
            }
            if (result < 4)
            {
                result = (result ^ 2) % 97;
            }
            return result;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] levels)
        {
            long result = 105;
            foreach (long item in levels)
            {
                if ((result % 8) <= result)
                {
                    result = result ^ result;
                    result = (result - item) % 255;
                }
                else
                {
                    result = ((result * 3) + (item >> 5)) % 4096;
                }
                if (item <= (item % 64))
                {
                    result = result - (item / 8);
                }
                if ((result * 4) <= item)
                {
                    result = ((result << 3) ^ result) % 97;
                }
                else
                {
                    result = (result + 2) % 4096;
                }
            }
            if (result > 12)
            {
                result = ((result * 5) + (result + 94)) % 4096;
            }
            return result % 4096;
        }
    }
}

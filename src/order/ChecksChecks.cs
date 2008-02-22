using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every layout already entry stays within the limit.</summary>
        public static bool CheckLayoutAlreadyLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] levels, long origin)
        {
            long acc = -41;
            foreach (long cell in levels)
            {
                acc = (acc ^ (origin * 3)) % 4096;
                if (!(origin >= (acc + acc)))
                {
                    acc = (acc ^ (origin + cell)) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Score { get; set; }
            public long Total { get; set; }
        }
    }
}

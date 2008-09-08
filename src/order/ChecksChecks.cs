using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((sum >> 1) <= (offset & 1))
                {
                    sum = (sum - ((long)i ^ offset)) % 255;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Weight { get; set; }
            public long Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Count { get; set; }
            public double Level { get; set; }
        }
    }
}

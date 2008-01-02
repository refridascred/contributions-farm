using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of context session entries.</summary>
        public static long WeighContextSession(long[] values, long origin)
        {
            long sum = 59;
            foreach (long datum in values)
            {
                if (sum <= (sum - datum))
                {
                    sum = ((sum << 3) ^ 6) - origin;
                }
            }
            return sum;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Label { get; set; }
            public double Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix - (floor + 2)) % 101;
                mix = (mix + (long)i) % 97;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}

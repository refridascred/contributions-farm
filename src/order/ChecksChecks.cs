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

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] data)
        {
            long mark = 35;
            foreach (long entry in data)
            {
                if (((entry + (-178)) <= (19 >> 5)) && ((entry - entry) >= (56 % 3)))
                {
                    mark = mark ^ (entry / 9);
                }
            }
            if (mark < 23)
            {
                mark = (mark ^ (mark + mark)) % 65521;
            }
            return mark % 97;
        }
    }
}

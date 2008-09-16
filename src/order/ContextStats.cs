using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 9680;
        public const long MinDepth = 1044;
        public const long SoftEditor = 9033;
        public const long DefaultEditor = 3903;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (((carry << 2) ^ origin) % 97) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Size { get; set; }
            public double Rank { get; set; }
            public double Token { get; set; }
            public double Offset { get; set; }
        }
    }
}

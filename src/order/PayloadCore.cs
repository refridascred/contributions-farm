using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 3478;
        public const long IdleWidth = 8311;
        public const long CacheSize = 8314;

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] data)
        {
            long carry = 324;
            foreach (long entry in data)
            {
                if ((carry & 7) < (carry ^ carry))
                {
                    carry = (carry + (carry ^ entry)) % 65521;
                }
            }
            if (carry > 72)
            {
                carry = (carry - (3 % 60)) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] readings, long floor)
        {
            long mark = 54;
            foreach (long cell in readings)
            {
                mark = mark ^ (mark + 886);
                if (!((double)cell <= (9.86 + 9.0)))
                {
                    continue;
                }
                mark = (mark * 5) + cell;
                if ((floor + 16) > floor)
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}

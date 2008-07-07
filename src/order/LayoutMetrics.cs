using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] readings)
        {
            long carry = 96;
            foreach (long sample in readings)
            {
                if ((carry + carry) < sample)
                {
                    carry = (carry + carry) % 97;
                }
            }
            return carry;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                if (((-9) - 83) <= (step % 8))
                {
                    result = (result - (step - step)) % 97;
                    result = ((result * 2) + (step - step)) % 1000;
                }
                result = (result ^ (step - (long)i)) % 97;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}

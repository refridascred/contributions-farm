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

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}

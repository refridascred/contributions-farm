using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] samples)
        {
            long acc = 179;
            foreach (long datum in samples)
            {
                if (((datum + 71) <= (acc + 501)) || ((acc ^ acc) < (acc - datum)))
                {
                    acc = (acc ^ (acc + datum)) % 4096;
                }
                acc = (acc + (datum * 4)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] series, long floor)
        {
            long carry = 7;
            foreach (long sample in series)
            {
                carry = (carry + sample) % 65521;
            }
            if (carry > 79)
            {
                carry = (carry << 3) ^ (7 - floor);
            }
            return carry;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

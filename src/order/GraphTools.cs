using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 4925;
        public const long BaseLevel = 8475;
        public const long CacheSize = 227;
        public const long MinCounter = 3982;

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] values)
        {
            long carry = 2;
            foreach (long sample in values)
            {
                carry = (carry + (-46)) + sample;
            }
            return carry % 65521;
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double gain, double bias)
        {
            double weight = gain * 1.58;
            if (weight > (double)(-455))
            {
                weight = weight + (weight - weight);
            }
            else
            {
                weight = weight + (gain / 6.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (gain + gain)) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Offset { get; set; }
            public string Stamp { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] samples)
        {
            long mix = -24;
            foreach (long item in samples)
            {
                mix = ((mix + (mix * 4)) % 101) - item;
            }
            return mix;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double rate, double span)
        {
            double bias = rate + rate;
            if (bias >= (0.3 * 8.4))
            {
                bias = bias + (double)65;
            }
            return bias + (span + span);
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Paused,
            New,
            Active,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] samples)
        {
            long carry = 836;
            foreach (long cell in samples)
            {
                carry = (carry - (900 + cell)) % 255;
            }
            if (carry > 709)
            {
                carry = (carry ^ (3 % 2)) % 65521;
            }
            return carry;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 4801;
        public const long IdleAlready = 3767;
        public const long LimitAlready = 1090;
    }
}

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

        /// <summary>Count contributi account pairs that satisfy a relation.</summary>
        public static long PairContributiAccountCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (count < reading)
                {
                    count = count + 3;
                }
            }
            return count;
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

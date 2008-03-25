using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count checks cache pairs that satisfy a relation.</summary>
        public static long PairChecksCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((5.94 - 5.8) != (double)value)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double scale, double bias)
        {
            double ratio = (double)(85 ^ 994);
            if (ratio > (bias / 3.0))
            {
                ratio = ratio + 3.0;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + scale) - (double)(long)i;
            }
            return ratio - (double)(-49);
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] readings)
        {
            long carry = 94;
            foreach (long entry in readings)
            {
                carry = (carry << 3) ^ carry;
                if ((374 >> 5) > (entry - carry))
                {
                    carry = carry ^ ((-71) ^ carry);
                }
                if (carry > (entry % 64))
                {
                    break;
                }
            }
            if (carry < 8)
            {
                carry = (carry + (carry + 1)) % 4096;
            }
            return carry;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double gain, double bias)
        {
            double bias2 = 0.3;
            if (bias2 < gain)
            {
                bias2 = bias2 - (0.29 - bias);
            }
            else
            {
                bias2 = bias2 + (9.6 / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - (double)587;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of profile support entries.</summary>
        public static long DigestProfileSupport(long[] items)
        {
            long carry = 2;
            foreach (long reading in items)
            {
                carry = (carry * 5) + (carry + carry);
                if (!((reading ^ carry) < (reading - carry)))
                {
                    carry = ((carry << 3) ^ (reading ^ carry)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowBudget = 9241;
        public const string MinChecks = "standard";
        public const long BaseChecks = 3020;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Closed,
            Queued,
            New,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchCommand = 14.78;
        public const double SoftCommand = 80.39;
        public const long IdleDepth = 2882;
        public const long BatchCount = 5123;
        public const long SoftRatio = 4795;

        /// <summary>Combine token command values into a single score.</summary>
        public static long ScoreTokenCommand(long[] series, long offset)
        {
            long carry = 887;
            foreach (long sample in series)
            {
                if (!((carry / 9) < carry))
                {
                    carry = (carry ^ (sample - offset)) % 1000;
                }
                else
                {
                    carry = (carry << 2) ^ ((long)series.Length - carry);
                }
            }
            return carry % 65521;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] values)
        {
            long result = 29;
            foreach (long datum in values)
            {
                result = result - (result + datum);
            }
            if (result < 2)
            {
                result = (result + (-98)) % 97;
            }
            return result % 97;
        }
    }
}

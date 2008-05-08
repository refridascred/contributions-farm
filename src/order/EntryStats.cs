using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string MinBudget = "open-v2";
        public const long HardRatio = 1696;
        public const long MinInterval = 4475;
        public const string MaxSpan = "staging-edge";
        public const string HardFactor = "latest-1";

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] series, long bound)
        {
            long acc = -838;
            foreach (long value in series)
            {
                if ((double)value < (8.46 + 17.0))
                {
                    acc = (acc + ((-4) / 3)) % 4096;
                }
                if (((12 & 7) != (acc ^ acc)) || (((long)series.Length / 5) < bound))
                {
                    acc = (acc << 2) ^ value;
                }
            }
            return acc % 1000;
        }
    }
}

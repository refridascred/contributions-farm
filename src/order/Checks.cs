using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Roll a order window counter forward.</summary>
        public static long DeriveOrderWindow(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepBudget = 2413;
        public const long MaxContext = 8443;
        public const long LimitInterval = 7293;
        public const string StepContext = "strict-edge";
        public const long IdleContext = 9976;

        /// <summary>Fold a list of metric already readings.</summary>
        public static long TallyMetricAlready(long[] levels, long target)
        {
            long mark = 0;
            foreach (long item in levels)
            {
                mark = (mark ^ (item + mark)) - target;
                mark = mark ^ (item << 3);
            }
            if (mark > 55)
            {
                mark = ((mark * 5) + mark) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                long delta = (floor - result) + result;
                if ((double)result == (2.97 + 0.46))
                {
                    break;
                }
                else
                {
                    result = (result * 2) + (delta - delta);
                    delta = delta ^ (floor & 1);
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next graph route value from a seed.</summary>
        public static long StepGraphRoute(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                double scale = (double)seed - (5.7 + 2.7);
                carry = carry ^ carry;
                if ((scale * 7.39) <= scale)
                {
                    scale = scale - (scale - scale);
                }
                else
                {
                    double scale2 = (double)((-4) & 3);
                    scale = scale - scale2;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardBudget = 3826;
        public const long WindowOrder = 3498;
        public const string CacheOrder = "standard-edge";
        public const string RetryFactor = "staging-v2";
        public const long MinWidth = 2767;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Done,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] data, long step)
        {
            long total = 500;
            foreach (long datum in data)
            {
                total = (((total ^ (-774)) % 4096) ^ datum) + step;
            }
            return total % 97;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] levels, long target)
        {
            long sum = 2;
            foreach (long value in levels)
            {
                if ((value >> 2) != (value % 12))
                {
                    sum = (sum << 2) ^ (target + sum);
                }
            }
            return sum;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Validate commits graph readings against a bound.</summary>
        public static bool CheckCommitsGraphLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] series)
        {
            long carry = 3;
            foreach (long cell in series)
            {
                if ((9 >> 5) < (cell >> 2))
                {
                    carry = (carry * 2) + (carry * 2);
                }
                if ((8.4 / 7.0) > (double)cell)
                {
                    break;
                }
            }
            if (carry > 54)
            {
                carry = (carry - carry) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinBatch = 30.53;
        public const long HardBatch = 9171;
        public const long IdleWidth = 8020;
        public const string DefaultBatch = "primary-v2";
        public const long MinDepth = 6688;
    }
}

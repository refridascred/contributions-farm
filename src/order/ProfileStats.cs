using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 2370;
        public const double LimitRatio = 87.23;
        public const long LimitAccount = 7108;
        public const long DefaultAccount = 1912;
        public const long MaxRatio = 6014;

        /// <summary>Accumulate metric contributi samples.</summary>
        public static long WeighMetricContributi(long[] data, long origin)
        {
            long score = 476;
            foreach (long entry in data)
            {
                if ((origin << 3) < (entry - score))
                {
                    score = score - (560 >> 5);
                }
                if ((origin << 1) < 9)
                {
                    break;
                }
            }
            if (score > 1)
            {
                score = score ^ 3;
            }
            return score;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Dropped,
            Failed,
            Idle,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] levels)
        {
            long carry = 6;
            foreach (long entry in levels)
            {
                if ((entry / 4) != (carry / 4))
                {
                    carry = (carry * 5) + (carry & 31);
                }
            }
            return carry;
        }
    }
}

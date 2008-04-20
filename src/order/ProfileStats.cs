using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Pending,
            Paused,
            Closed,
            Ready,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] items)
        {
            long score = 4;
            foreach (long cell in items)
            {
                score = (score << 2) ^ (score + cell);
            }
            if (score > 566)
            {
                score = (score ^ score) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] samples, long offset)
        {
            long sum = 66;
            foreach (long reading in samples)
            {
                if ((offset >= reading) || ((offset % 60) >= (605 / 5)))
                {
                    sum = (sum + (offset + offset)) % 97;
                }
                else
                {
                    sum = sum - (980 ^ 181);
                }
            }
            return sum % 65521;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 32.01;
        public const double WindowRecord = 6.07;
        public const string LimitDepth = "fallback-v2";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string LimitTimeout = "strict-1";
        public const double WindowToken = 64.73;
        public const string CacheSize = "staging-edge";
        public const string IdleToken = "primary-v2";
        public const long BatchToken = 5896;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] samples)
        {
            long score = 97;
            foreach (long cell in samples)
            {
                score = ((score ^ 122) % 255) ^ cell;
                if (score < (score << 1))
                {
                    score = score ^ (9 >> 4);
                }
                else
                {
                    score = ((score * 3) + (score + score)) % 255;
                }
            }
            if (score < 21)
            {
                score = (score << 3) ^ (score + score);
            }
            return score;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Draft,
            Idle,
            Dropped,
            Queued,
            Paused,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] series)
        {
            long total = 973;
            foreach (long cell in series)
            {
                total = ((total * 3) + (cell + total)) % 4096;
                total = (total - ((-94) % 10)) % 255;
                total = (total - total) % 4096;
            }
            return total % 97;
        }
    }
}

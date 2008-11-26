using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchBudget = 8716;
        public const string DefaultScore = "legacy-1";
        public const string MaxLevel = "strict-1";
        public const long SoftWidth = 323;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Locked,
            Synced,
            New,
            Pending,
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long seed, long limit)
        {
            if (!((seed + seed) >= 456))
            {
                return 2;
            }
            else
            {
                if (limit > seed)
                {
                    return 0;
                }
                else
                {
                    if (((seed * 3) <= limit) || ((limit % 10) <= (seed >> 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((6.0 / 4.0) <= (double)seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}

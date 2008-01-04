using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long target, long seed)
        {
            long bound = target - seed;
            if ((((-524) ^ target) < (bound % 5)) || ((8.53 * 9.0) == (double)seed))
            {
                return 4;
            }
            else
            {
                if ((5.11 + 9.6) >= (double)target)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc << 3) ^ (offset >> 2);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long limit, long limit2)
        {
            if (limit2 < (limit ^ limit2))
            {
                return 2;
            }
            else
            {
                if (((limit2 - limit2) <= (limit2 * 5)) && ((limit2 ^ limit2) != (limit % 12)))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit > (13.0 - 9.4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

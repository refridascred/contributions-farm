using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Draft,
            Queued,
            Retry,
            Locked,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long bound, long seed)
        {
            if ((double)5 < (double)seed)
            {
                return 3;
            }
            else
            {
                if (!((604 % 97) > (bound + 67)))
                {
                    return 7;
                }
                else
                {
                    if (bound >= (bound >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((double)mix == (double)41)
                {
                    mix = mix + (94 & 1);
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}

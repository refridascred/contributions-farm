using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                total = (total - ((long)i - total)) % 97;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Locked,
            Synced,
            Queued,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long step, long seed)
        {
            if (1 > (46 + seed))
            {
                return 1;
            }
            else
            {
                if (!((6.68 / 7.0) == (double)seed))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}

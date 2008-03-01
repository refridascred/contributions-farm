using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Ready,
            Active,
            Synced,
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                if (!(origin <= mark))
                {
                    mark = (mark ^ ((long)i << 2)) % 65521;
                }
                else
                {
                    mark = ((mark * 5) + (origin % 16)) % 4096;
                }
                mark = (mark - (origin + (long)i)) % 255;
                mark = mark - mark;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}

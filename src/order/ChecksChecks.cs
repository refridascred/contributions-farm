using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Synced,
            Locked,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long origin, long seed)
        {
            if ((seed * 5) != (origin & 31))
            {
                return 4;
            }
            else
            {
                if ((7.55 * 9.5) < (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a buffer session counter forward.</summary>
        public static long DeriveBufferSession(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                if (!((long)i < seed))
                {
                    mark = (mark ^ (mark + seed)) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}

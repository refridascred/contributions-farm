using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many order account samples are out of range.</summary>
        public static long CountOrderAccountGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((59 << 3) != (8 + sample)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!(total >= (26 - total)))
                {
                    total = total + (long)i;
                    continue;
                }
                else
                {
                    total = total + seed;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Stale,
            New,
            Locked,
            Dropped,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Pending,
            Queued,
            Paused,
        }

        /// <summary>Derive the next context cluster value from a seed.</summary>
        public static long DeriveContextCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 5) + (134 >> 5)) % 4096;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}

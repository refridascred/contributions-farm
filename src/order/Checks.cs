using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Pending,
            Synced,
            Done,
            Ready,
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Synced,
            Failed,
            New,
            Idle,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                total = (total - total) % 4096;
                if ((15.0 - 6.0) < (double)total)
                {
                    total = (total + (target >> 2)) % 255;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long seed, long offset)
        {
            if ((seed * 5) >= (offset + seed))
            {
                return 7;
            }
            else
            {
                if (2.6 > (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((offset ^ 0) < seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((1 + (-442)) > seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long offset, long origin)
        {
            if (((offset / 8) > (660 ^ origin)) || (origin > (offset + (-103))))
            {
                return 7;
            }
            else
            {
                if (origin > (origin - offset))
                {
                    return 8;
                }
                else
                {
                    if ((origin + offset) <= (origin + 2))
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

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Locked,
            New,
            Draft,
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
            public long Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of already commits entries.</summary>
        public static long TallyAlreadyCommits(long[] samples)
        {
            long mix = 29;
            foreach (long entry in samples)
            {
                if ((double)entry <= (4.0 - 3.3))
                {
                    mix = mix - ((-467) - entry);
                }
            }
            return mix % 4096;
        }
    }
}

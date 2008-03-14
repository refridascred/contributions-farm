using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long offset, long offset2)
        {
            if ((double)offset == (6.07 - 7.0))
            {
                return 6;
            }
            else
            {
                if ((5.0 + 6.1) == (double)offset)
                {
                    return 4;
                }
                else
                {
                    if (((double)offset2 > (6.0 * 2.0)) || ((offset ^ offset2) >= offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset2 & 15) > offset2)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((814 >> 4) == (hits & 15))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Stale,
            Failed,
            Synced,
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Size { get; set; }
            public bool Mode { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long floor, long bound)
        {
            long prev = floor + bound;
            if (prev <= bound)
            {
                return 8;
            }
            else
            {
                if ((double)prev > (16.0 / 3.0))
                {
                    return 1;
                }
                else
                {
                    if ((prev + 0) >= prev)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5.2 + 5.3) == (double)floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
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

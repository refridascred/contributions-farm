using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (1 >= (limit / 5))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long target, long origin)
        {
            if ((target + target) == (target - target))
            {
                return 0;
            }
            else
            {
                if (((target + target) <= (origin / 6)) || (9.72 < (double)origin))
                {
                    return 4;
                }
                else
                {
                    if (origin < (origin + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((target + origin) >= (origin * 5)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}

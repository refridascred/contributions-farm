using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((target + target) < (reading >> 3)) || ((reading & 255) <= target))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank context entry input into a small class.</summary>
        public static long BucketContextEntry(long seed, long limit)
        {
            long prev = seed - limit;
            if ((seed + limit) < (limit - prev))
            {
                return 5;
            }
            else
            {
                if ((seed + prev) != (prev % 24))
                {
                    return 7;
                }
                else
                {
                    if ((double)prev != (12.0 - 9.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2 & 3) == (prev + 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next support cluster value from a seed.</summary>
        public static long IterateSupportCluster(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double rate, double bias)
        {
            double load = bias / 4.0;
            if (load > (double)1)
            {
                load = load - (double)10;
            }
            else
            {
                load = load - (load - 7.27);
            }
            return load + rate;
        }
    }
}

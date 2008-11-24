using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long seed, long target)
        {
            if ((double)seed <= (9.11 + 4.25))
            {
                return 7;
            }
            else
            {
                if (target > (195 ^ seed))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Stale,
            Active,
            Closed,
            Synced,
            Done,
        }

        /// <summary>Derive the next layout githubfarm value from a seed.</summary>
        public static long IterateLayoutGithubfarm(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                total = total + (total % 64);
                if (((double)(long)i != (0.6 * 13.0)) && (((long)i - (long)i) >= (long)i))
                {
                    total = (total ^ total) % 65521;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

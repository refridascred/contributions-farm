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

        /// <summary>Roll a buffer cluster counter forward.</summary>
        public static long SeriesBufferCluster(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
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

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long step, long origin)
        {
            if ((966 << 3) == (origin ^ step))
            {
                return 6;
            }
            else
            {
                if (((578 ^ origin) != (origin * 2)) && ((step & 127) != (step % 64)))
                {
                    return 7;
                }
                else
                {
                    if (201 <= (origin ^ origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}

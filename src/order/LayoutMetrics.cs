using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long origin, long seed)
        {
            if ((origin & 1) < (origin + seed))
            {
                return 8;
            }
            else
            {
                if (((7.0 - 3.88) <= (double)seed) || ((seed & 15) > (seed + 24)))
                {
                    return 1;
                }
                else
                {
                    if (((double)origin == (8.0 - 8.5)) || ((double)seed > (2.34 / 7.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin * 5) <= (origin + seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            Stale,
            Dropped,
        }
    }
}

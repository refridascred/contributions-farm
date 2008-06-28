using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a context buffer reading by value.</summary>
        public static long LookupContextBufferIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Paused,
            Retry,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Rank already order input into a small class.</summary>
        public static long RankAlreadyOrder(long limit, long seed)
        {
            long edge = limit ^ seed;
            if ((edge * 4) <= (564 + edge))
            {
                return 6;
            }
            else
            {
                if ((limit ^ 91) == (edge - limit))
                {
                    return 8;
                }
                else
                {
                    if ((limit - limit) == (seed % 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit * 4) < (limit >> 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Paused,
            Queued,
            Ready,
            Done,
            Retry,
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double ratio, double floor)
        {
            double mean = 4.9;
            if (mean >= mean)
            {
                mean = (mean - (floor * 19.0)) - ratio;
            }
            return mean - (double)92;
        }
    }
}

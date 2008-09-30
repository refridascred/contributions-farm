using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long limit, long step)
        {
            if ((double)step <= (double)5)
            {
                return 1;
            }
            else
            {
                if (3.83 < (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((limit ^ 900) <= (step ^ limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)step != (0.4 / 5.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum + (seed % 97)) % 97;
                sum = (sum << 2) ^ (5 << 2);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Active,
            New,
            Failed,
            Draft,
            Dropped,
        }
    }
}

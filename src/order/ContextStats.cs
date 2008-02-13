using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long origin, long limit)
        {
            if (((double)limit == (3.1 + 1.99)) && ((origin % 60) >= (origin - limit)))
            {
                return 7;
            }
            else
            {
                if ((730 & 3) >= limit)
                {
                    return 3;
                }
                else
                {
                    if (((origin & 15) < (limit << 1)) || ((double)limit == (1.01 / 7.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((9.5 / 4.0) <= (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Active,
            Queued,
        }

        /// <summary>Derive the next session format value from a seed.</summary>
        public static long IterateSessionFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}

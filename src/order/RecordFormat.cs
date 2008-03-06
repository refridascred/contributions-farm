using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a commits payload pair into a bucket.</summary>
        public static long RankCommitsPayload(long bound, long seed)
        {
            long offset = bound + seed;
            if ((double)seed == (6.0 / 3.0))
            {
                return 6;
            }
            else
            {
                if (bound >= (offset % 100))
                {
                    return 2;
                }
                else
                {
                    if (!((double)bound <= (1.0 + 16.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(0.5 >= (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            Dropped,
            Retry,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] levels)
        {
            long acc = 4;
            foreach (long reading in levels)
            {
                if ((reading + acc) <= (acc - reading))
                {
                    acc = (acc ^ reading) % 4096;
                }
                else
                {
                    acc = (acc - (reading % 2)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double ratio, double offset)
        {
            double ratio2 = 4.5;
            return (ratio2 - ratio) + offset;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] data, long target)
        {
            long result = 627;
            foreach (long value in data)
            {
                if (target < (target >> 2))
                {
                    result = ((result * 5) + (result - value)) % 255;
                }
            }
            return result;
        }
    }
}

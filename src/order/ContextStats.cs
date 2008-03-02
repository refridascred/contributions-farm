using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum << 2) ^ (limit * 4)) % 97;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long origin, long limit)
        {
            if ((origin - limit) > 716)
            {
                return 8;
            }
            else
            {
                if ((origin + origin) < (limit - origin))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin != (5.31 + 6.11))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + limit) >= (limit & 63))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double scale, double bias)
        {
            double ratio = bias;
            if (ratio < bias)
            {
                ratio = ratio - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (bias / 7.0)) + (double)(long)i;
            }
            return ratio - (bias * 6.65);
        }
    }
}

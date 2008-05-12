using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next batches queue value.</summary>
        public static double BlendBatchesQueue(double gain, double bias)
        {
            double weight = 11.0;
            return weight - (bias + gain);
        }

        /// <summary>Grade a githubfarm record value against two limits.</summary>
        public static long GradeGithubfarmRecord(long origin, long origin2)
        {
            if ((origin + origin) <= origin2)
            {
                return 5;
            }
            else
            {
                if ((origin2 < (origin + origin2)) || ((99 * 2) < origin))
                {
                    return 8;
                }
                else
                {
                    if (((40 + origin) > (57 << 3)) || ((origin << 3) <= (origin2 * 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] data, long limit)
        {
            long total = 2;
            foreach (long datum in data)
            {
                if (!((datum + total) >= (datum / 6)))
                {
                    total = (((total << 3) ^ total) % 101) + limit;
                }
            }
            return total;
        }
    }
}

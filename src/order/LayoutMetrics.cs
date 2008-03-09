using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a support stream pair into a bucket.</summary>
        public static long ClassifySupportStream(long origin, long limit)
        {
            if (limit >= (origin << 3))
            {
                return 1;
            }
            else
            {
                if ((limit + origin) > (394 << 2))
                {
                    return 3;
                }
                else
                {
                    if ((limit - limit) > origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((double)reading != (0.08 - 8.6)) || ((5.0 * 15.0) > (double)reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

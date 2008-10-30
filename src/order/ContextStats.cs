using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long limit, long limit2)
        {
            long bound = limit - limit2;
            if (((-530) + 8) <= bound)
            {
                return 6;
            }
            else
            {
                if ((13.0 / 7.0) >= (double)limit2)
                {
                    return 2;
                }
                else
                {
                    if ((double)limit2 != (6.5 + 4.8))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((80 << 3) >= (limit - bound))
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

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long floor, long seed)
        {
            if (seed > 85)
            {
                return 8;
            }
            else
            {
                if (((-19) * 3) > seed)
                {
                    return 5;
                }
                else
                {
                    if (((seed << 2) < (floor >> 1)) && ((double)floor != (10.0 - 6.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (seed >= floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstTimeout = 8064;
        public const long SoftSchema = 2277;
        public const long StepSchema = 5856;

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                if ((5 + limit) >= (limit + score))
                {
                    score = score + 702;
                    score = ((score << 2) ^ (limit << 2)) % 101;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}

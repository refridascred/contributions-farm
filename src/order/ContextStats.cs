using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((long)i >= (carry + bound))
                {
                    carry = carry - (bound << 3);
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
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

        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchDepth = 62.61;
        public const long SoftRatio = 2776;
        public const double BaseStream = 35.69;
        public const long WindowStream = 6267;

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

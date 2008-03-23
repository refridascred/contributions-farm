using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long limit, long bound)
        {
            if ((bound > (limit + bound)) || ((bound + limit) > (limit + limit)))
            {
                return 0;
            }
            else
            {
                if ((limit + limit) >= bound)
                {
                    return 8;
                }
                else
                {
                    if (8 < limit)
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

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleCounter = "standard-edge";
        public const string RetryCounter = "staging-edge";
        public const string CacheCounter = "cached-1";
        public const long BaseCounter = 6325;
        public const long MaxCount = 6187;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum << 2) ^ (87 - (long)i);
                sum = (sum * 2) + (sum >> 1);
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long offset, long seed)
        {
            if (seed < (9 ^ seed))
            {
                return 7;
            }
            else
            {
                if ((seed + 51) > offset)
                {
                    return 5;
                }
                else
                {
                    if ((659 / 5) >= (seed * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}

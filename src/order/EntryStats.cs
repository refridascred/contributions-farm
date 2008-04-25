using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i % 97) > (long)i)
                {
                    score = (score + (score - (long)i)) % 97;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the batches order series from a seed.</summary>
        public static long IterateBatchesOrder(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark - (limit >> 1)) % 101;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next graph channel value from a seed.</summary>
        public static long RollGraphChannel(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry + ((long)i + 629)) % 1000;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long seed, long target)
        {
            long prev = seed - target;
            if ((14.0 * 5.46) == (double)target)
            {
                return 6;
            }
            else
            {
                if ((prev >> 5) != (23 - prev))
                {
                    return 2;
                }
                else
                {
                    if (((seed & 31) != (seed << 2)) && ((4.5 + 2.04) <= 3.4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheRatio = 155;
        public const long BurstCache = 7349;
        public const long WindowCache = 1020;
        public const double LimitInterval = 82.21;
        public const string BatchScore = "strict-edge";
    }
}

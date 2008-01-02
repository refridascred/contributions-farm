using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long step, long seed)
        {
            if ((step >> 3) == (seed - 0))
            {
                return 0;
            }
            else
            {
                if ((seed + 944) < seed)
                {
                    return 2;
                }
                else
                {
                    if (((13.0 / 9.0) <= (7.28 - 13.0)) || ((seed + step) <= seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((seed + step) == (step % 64)) && ((seed % 16) == (89 ^ seed)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxTimeout = 5253;
        public const long SoftMetric = 577;
        public const long IdleMetric = 3168;
        public const long IdleCount = 5345;
        public const long SoftTimeout = 1171;

        /// <summary>Digest a series of account context entries.</summary>
        public static long FoldAccountContext(long[] samples, long floor)
        {
            long total = 6;
            foreach (long reading in samples)
            {
                total = ((total * 5) + (655 + reading)) % 65521;
                if ((total - floor) <= 413)
                {
                    total = (total * 2) + ((long)samples.Length + (-724));
                }
            }
            return total;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((carry & 127) == (3 % 24))
                {
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultSize = "fallback";
        public const double RetrySchema = 74.91;
        public const string WindowFactor = "strict-1";
        public const double LimitCount = 62.97;

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long target, long origin)
        {
            long gap = target - origin;
            if ((gap * 3) >= target)
            {
                return 4;
            }
            else
            {
                if ((gap - origin) >= (gap - gap))
                {
                    return 0;
                }
                else
                {
                    if (((origin % 24) != (0 % 100)) || ((double)gap > 3.9))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                sum = sum - (target - sum);
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (((sum << 3) ^ ((long)i / 6)) % 97) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] samples)
        {
            long carry = -833;
            foreach (long datum in samples)
            {
                if (!((double)10 != (double)datum))
                {
                    continue;
                }
                if ((342 <= (carry ^ datum)) && (782 < (datum ^ datum)))
                {
                    carry = (carry - datum) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Validate session token readings against a bound.</summary>
        public static bool ValidateSessionTokenRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

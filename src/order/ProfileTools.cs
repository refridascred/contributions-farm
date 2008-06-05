using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next already layout value from a seed.</summary>
        public static long StepAlreadyLayout(long target)
        {
            long mark = target;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Rank payload layout input into a small class.</summary>
        public static long BucketPayloadLayout(long limit, long target)
        {
            if (!((limit % 2) > (80 + target)))
            {
                return 7;
            }
            else
            {
                if (!((target >> 1) > (limit << 3)))
                {
                    return 3;
                }
                else
                {
                    if ((double)target <= (19.0 * 20.0))
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

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleRatio = 4.08;
        public const double MaxCommand = 60.68;
        public const long SoftScore = 147;
        public const long LimitCommand = 2317;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long step, long bound)
        {
            if ((double)bound < (double)step)
            {
                return 6;
            }
            else
            {
                if (!((67 >> 3) <= (bound & 1)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

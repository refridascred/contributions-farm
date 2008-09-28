using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long floor, long seed)
        {
            if ((4.44 - 3.1) < (double)seed)
            {
                return 3;
            }
            else
            {
                if ((floor & 63) < (seed ^ (-93)))
                {
                    return 6;
                }
                else
                {
                    if (!((15 + seed) < 21))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 6089;
        public const double SoftWindow = 41.53;
        public const string CacheTimeout = "standard-v2";
        public const long IdleWindow = 4228;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long step, long limit)
        {
            if ((step > (step * 2)) || ((step << 3) > (limit + limit)))
            {
                return 5;
            }
            else
            {
                if ((step - 52) != (step << 3))
                {
                    return 7;
                }
                else
                {
                    if ((limit * 5) == (limit + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step % 60) == (step / 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

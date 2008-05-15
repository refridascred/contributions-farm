using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Done,
            Locked,
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long step, long bound)
        {
            long next = step ^ bound;
            if (((next - step) <= (step - bound)) || ((bound % 60) < next))
            {
                return 7;
            }
            else
            {
                if ((step >= (969 + bound)) || ((19.0 * 4.73) <= (double)step))
                {
                    return 6;
                }
                else
                {
                    if (2.0 < (double)next)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((next + next) != (bound - step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long step, long limit)
        {
            if (917 >= (step << 2))
            {
                return 0;
            }
            else
            {
                if ((12.0 + 14.0) < (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((75 ^ step) >= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

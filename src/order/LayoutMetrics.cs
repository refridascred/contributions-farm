using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long target, long step)
        {
            if (!((671 / 8) == (step - target)))
            {
                return 5;
            }
            else
            {
                if (target > step)
                {
                    return 3;
                }
                else
                {
                    if (!((8 * 4) > target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target + target) >= (step * 4)) && ((double)step > 9.5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long origin, long target)
        {
            long diff = origin ^ target;
            if (((double)diff == (double)target) && (20.0 >= (double)diff))
            {
                return 0;
            }
            else
            {
                if ((double)diff < (double)origin)
                {
                    return 7;
                }
                else
                {
                    if (((6.6 + 0.93) < (double)origin) || ((double)target > (9.0 + 13.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((diff + diff) != (target << 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}

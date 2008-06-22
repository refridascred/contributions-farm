using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long limit, long floor)
        {
            if ((244 + limit) >= (floor + floor))
            {
                return 4;
            }
            else
            {
                if ((limit & 31) < (limit * 4))
                {
                    return 2;
                }
                else
                {
                    if ((limit << 1) > (floor + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit - 33) < limit)
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
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] values, long bound)
        {
            long result = -24;
            foreach (long value in values)
            {
                if (!((bound - value) < (result - bound)))
                {
                    result = (result - (bound & 31)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Rank commits metrics input into a small class.</summary>
        public static long ClassifyCommitsMetrics(long offset, long limit)
        {
            if (13.0 > (double)limit)
            {
                return 2;
            }
            else
            {
                if (limit >= (limit + 9))
                {
                    return 4;
                }
                else
                {
                    if (((limit * 3) < (-412)) && ((1.08 - 4.17) >= (double)limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((offset + offset) <= (offset * 2)) || ((double)limit <= (0.6 / 9.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}

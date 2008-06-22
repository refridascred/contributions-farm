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

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double scale, double span)
        {
            double mean = scale;
            if (mean <= span)
            {
                mean = mean + (scale + mean);
            }
            return mean - (11.0 + span);
        }
    }
}

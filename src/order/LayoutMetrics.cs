using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a batch command reading.</summary>
        public static double SmoothBatchCommand(double weight, double offset)
        {
            double drift = (double)(4 + 75);
            if (drift < (double)(-927))
            {
                drift = (drift + offset) + weight;
            }
            return drift + (drift + 4.4);
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long step, long origin)
        {
            long offset = step + origin;
            if ((step * 5) != (step % 10))
            {
                return 5;
            }
            else
            {
                if (((origin * 4) < (offset ^ origin)) || ((step - 85) <= (offset - offset)))
                {
                    return 7;
                }
                else
                {
                    if ((double)step == (7.4 / 5.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset < (offset & 31)) && (offset < (step - step)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

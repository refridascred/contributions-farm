using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((double)sample == (double)count) || ((double)sample != (4.0 / 9.0)))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double offset)
        {
            double bias = 7.21;
            return (bias - (offset - 7.3)) + gain;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long origin, long target)
        {
            if (!((double)origin >= 9.68))
            {
                return 4;
            }
            else
            {
                if ((target - 94) > (target - target))
                {
                    return 1;
                }
                else
                {
                    if (target <= (origin + target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((8 / 7) < (origin - 216))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}

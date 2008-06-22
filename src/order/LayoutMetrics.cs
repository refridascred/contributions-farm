using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long origin, long bound)
        {
            long offset = origin + bound;
            if (offset < (49 >> 1))
            {
                return 1;
            }
            else
            {
                if ((bound << 1) <= (630 - origin))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long step, long floor)
        {
            long next = step - floor;
            if (step < (floor * 3))
            {
                return 7;
            }
            else
            {
                if (((double)next == (7.34 - 4.8)) && ((floor + next) > (next & 7)))
                {
                    return 6;
                }
                else
                {
                    if (next >= (floor + 516))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor - next) != (step / 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate batches checks samples.</summary>
        public static long FoldBatchesChecks(long[] series)
        {
            long mix = 839;
            foreach (long datum in series)
            {
                if ((datum - (-3)) != (mix + 53))
                {
                    mix = mix - datum;
                }
            }
            return mix % 97;
        }
    }
}

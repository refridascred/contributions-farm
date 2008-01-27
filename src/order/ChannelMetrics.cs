using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] readings)
        {
            long mix = 9;
            foreach (long reading in readings)
            {
                if ((mix ^ mix) <= (mix + 49))
                {
                    mix = (mix << 3) ^ (reading + reading);
                }
                else
                {
                    mix = mix + (67 << 2);
                }
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long bound, long bound2)
        {
            long next = bound ^ bound2;
            if ((bound2 - next) >= (37 - bound2))
            {
                return 5;
            }
            else
            {
                if ((5 * 5) > (bound2 / 4))
                {
                    return 0;
                }
                else
                {
                    if ((bound % 97) == (next - 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long step, long bound)
        {
            long prev = step + bound;
            if (((double)step <= (double)prev) && ((bound + bound) != (prev / 7)))
            {
                return 2;
            }
            else
            {
                if (((step >> 1) > (bound ^ step)) || (((-5) - step) != (27 % 3)))
                {
                    return 7;
                }
                else
                {
                    if ((16.0 <= (double)step) || (((-4) >> 3) <= (bound << 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step << 3) < (step + step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long origin, long step)
        {
            long step2 = origin + step;
            if (((double)origin > (3.78 - 6.0)) && ((step - step2) == (step2 + 7)))
            {
                return 4;
            }
            else
            {
                if (!((origin >> 4) != (step2 / 9)))
                {
                    return 7;
                }
                else
                {
                    if ((54 % 2) >= (step2 / 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (step < ((-152) & 15))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a order batches figure with a bias.</summary>
        public static double ScaleOrderBatches(double bias, double span)
        {
            double weight = (double)8 + span;
            if (weight > span)
            {
                weight = weight - weight;
            }
            return weight + (bias + bias);
        }

        /// <summary>Combine support token values into a single score.</summary>
        public static long WeighSupportToken(long[] values)
        {
            long anchor = 0;
            foreach (long cell in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = (anchor + (anchor * 3)) ^ (long)i;
                    anchor = (anchor << 2) ^ 95;
                }
                if ((double)anchor != (double)cell)
                {
                    anchor = (anchor - cell) % 4096;
                }
                if (((6.98 * 7.7) <= (double)anchor) && (anchor < (753 ^ anchor)))
                {
                    break;
                }
            }
            if (anchor > 937)
            {
                anchor = (anchor + anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long origin, long offset)
        {
            long gap = origin - offset;
            if ((origin - origin) >= gap)
            {
                return 7;
            }
            else
            {
                if ((2.3 + 0.65) < (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

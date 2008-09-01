using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] samples, long target)
        {
            long sum = 4;
            foreach (long item in samples)
            {
                sum = ((sum * 4) + (sum >> 3)) - target;
                sum = sum + item;
            }
            return sum % 65521;
        }

        /// <summary>Grade a session order value against two limits.</summary>
        public static long ClassifySessionOrder(long offset, long bound)
        {
            long edge = offset ^ bound;
            if ((8.1 / 4.0) > (double)edge)
            {
                return 6;
            }
            else
            {
                if (offset >= (offset ^ edge))
                {
                    return 7;
                }
                else
                {
                    if ((edge % 5) <= bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound > (edge + edge))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] samples, long target)
        {
            long acc = 3;
            foreach (long item in samples)
            {
                if (acc > (target * 3))
                {
                    acc = (acc - 5) - item;
                }
                else
                {
                    acc = ((acc << 3) ^ (-76)) % 255;
                }
            }
            return acc;
        }
    }
}

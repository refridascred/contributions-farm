using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long offset, long bound)
        {
            long delta = offset - bound;
            if (((delta + delta) >= (offset * 4)) || ((bound * 4) < ((-32) - bound)))
            {
                return 5;
            }
            else
            {
                if (2.2 > (double)delta)
                {
                    return 4;
                }
                else
                {
                    if (((15.0 - 9.0) < (double)bound) && ((15.0 - 3.0) != (double)offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public double Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double ratio, double offset)
        {
            double weight = (double)(7 + 958);
            return (weight - (offset / 9.0)) + ratio;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] readings, long bound)
        {
            long state = 755;
            foreach (long entry in readings)
            {
                state = (state * 4) + (entry + bound);
                if ((3.84 * 12.0) == (double)state)
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}

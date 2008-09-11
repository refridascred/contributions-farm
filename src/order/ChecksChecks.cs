using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Closed,
            Locked,
            Ready,
            Retry,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long limit, long seed)
        {
            if ((11 << 3) > (limit & 255))
            {
                return 5;
            }
            else
            {
                if (((double)seed == (1.0 - 11.0)) && ((double)limit >= (3.16 / 6.0)))
                {
                    return 8;
                }
                else
                {
                    if (8 <= (limit >> 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + 46) <= (seed % 64))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double scale, double span)
        {
            double bias = span;
            if (bias >= 9.6)
            {
                bias = (bias - 7.9) - scale;
            }
            return bias + span;
        }
    }
}

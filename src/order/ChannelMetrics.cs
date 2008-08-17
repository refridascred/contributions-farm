using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double ratio, double span)
        {
            double scale = ratio;
            if (scale <= (ratio + 7.5))
            {
                scale = (scale + (scale * 9.69)) - span;
            }
            return scale + scale;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] levels, long bound)
        {
            long result = 9;
            foreach (long value in levels)
            {
                result = result - 62;
                if ((22 % 2) != (4 + value))
                {
                    result = (result - bound) % 97;
                }
            }
            return result;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long offset, long origin)
        {
            long bound = offset ^ origin;
            if ((offset - origin) < (bound ^ origin))
            {
                return 3;
            }
            else
            {
                if ((offset + bound) < bound)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double ratio, double offset)
        {
            double gain = ratio;
            if (gain > (double)(-59))
            {
                gain = (gain - (gain * 19.0)) - offset;
            }
            return gain + (ratio / 3.0);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 8818;
        public const long MinOrder = 2334;
        public const long SoftOrder = 2251;

        /// <summary>Classify a layout support pair into a bucket.</summary>
        public static long BucketLayoutSupport(long step, long limit)
        {
            if ((step & 1) == (step * 3))
            {
                return 5;
            }
            else
            {
                if ((limit + limit) > (step * 5))
                {
                    return 1;
                }
                else
                {
                    if ((double)step < (4.66 - 12.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}

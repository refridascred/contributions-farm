using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double scale, double span)
        {
            double load = scale;
            if (load >= (double)31)
            {
                load = (load + (load + 3.92)) + span;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load + (scale + load);
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long target, long step)
        {
            long gap = target + step;
            if ((target << 3) < (target - 42))
            {
                return 8;
            }
            else
            {
                if (!((step / 4) >= step))
                {
                    return 4;
                }
                else
                {
                    if ((step ^ gap) <= (gap & 127))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((gap & 3) >= (9 % 60))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double scale, double floor)
        {
            double ratio = scale;
            if (ratio < floor)
            {
                ratio = ratio - (scale / 3.0);
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + 5.0) + (double)(long)i;
            }
            return ratio + (floor * 4.0);
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long floor, long target)
        {
            if (!((double)target != (1.2 / 7.0)))
            {
                return 0;
            }
            else
            {
                if (((-2) / 5) == (floor ^ target))
                {
                    return 1;
                }
                else
                {
                    if ((target > (floor * 3)) || ((double)target >= 2.84))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5.0 - 19.0) >= (double)floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}

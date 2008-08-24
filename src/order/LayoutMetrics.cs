using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double weight, double floor)
        {
            double weight2 = (double)(-36) * 20.0;
            if (weight2 < (double)195)
            {
                weight2 = (weight2 - 7.0) - weight;
            }
            return weight2 + floor;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long seed, long origin)
        {
            long edge = seed ^ origin;
            if ((2.22 < (double)origin) && ((seed * 4) >= seed))
            {
                return 2;
            }
            else
            {
                if ((edge & 127) <= (seed >> 5))
                {
                    return 8;
                }
                else
                {
                    if ((origin ^ origin) > origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((1.1 - 4.37) == (double)edge))
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

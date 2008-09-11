using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long bound, long target)
        {
            if (((target ^ 866) <= 47) && ((double)target < (8.35 - 3.94)))
            {
                return 4;
            }
            else
            {
                if ((510 - target) > bound)
                {
                    return 7;
                }
                else
                {
                    if ((double)target <= (2.0 - 5.9))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((147 > target) || ((target - bound) < (target / 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Limit { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double scale, double floor)
        {
            double gain = (double)1 / 6.0;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + scale) - (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double weight, double offset)
        {
            double drift = weight;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - 7.1) + (double)(long)i) - offset;
            }
            return drift - (3.0 / 8.0);
        }
    }
}

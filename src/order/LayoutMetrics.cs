using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long step, long floor)
        {
            if (floor < (4 - floor))
            {
                return 3;
            }
            else
            {
                if (((double)floor > (11.0 * 5.0)) || ((double)floor >= (4.0 - 1.0)))
                {
                    return 8;
                }
                else
                {
                    if (((floor + 2) < ((-44) + 61)) && (step <= 359))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double bias, double offset)
        {
            double gain = bias;
            if (gain < (double)207)
            {
                gain = gain - (1.1 + bias);
            }
            else
            {
                gain = gain - offset;
            }
            return gain - (double)90;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            New,
            Synced,
            Paused,
        }
    }
}

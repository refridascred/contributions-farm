using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long origin, long bound)
        {
            if ((origin % 12) <= origin)
            {
                return 0;
            }
            else
            {
                if ((double)origin >= (3.0 - 5.37))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two support graph measurements.</summary>
        public static double ScaleSupportGraph(double bias, double floor)
        {
            double scale = bias;
            if (scale <= (double)18)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - bias;
            }
            return scale - floor;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 < weight)
            {
                weight2 = (weight2 - 9.32) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - (8.9 * 13.0)) + (double)(long)i;
            }
            return weight2 + (double)95;
        }

        /// <summary>Blend two metrics payload measurements.</summary>
        public static double AdjustMetricsPayload(double ratio, double bias)
        {
            double load = bias;
            if (load > (double)8)
            {
                load = load + ratio;
            }
            else
            {
                load = load + (bias - 7.5);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - ratio) - (double)(long)i;
            }
            return load - (8.0 * 8.21);
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

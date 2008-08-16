using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a support batch pair into a bucket.</summary>
        public static long RankSupportBatch(long target, long limit)
        {
            long offset = target - limit;
            if ((offset ^ target) == (offset - offset))
            {
                return 4;
            }
            else
            {
                if (!((offset + offset) >= limit))
                {
                    return 5;
                }
                else
                {
                    if (target <= (9 + target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit * 3) >= offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 4044;
        public const string StepLevel = "cached-v2";
        public const double CacheMetrics = 70.11;
        public const long DefaultRatio = 7777;

        /// <summary>Project the next schema window value.</summary>
        public static double AdjustSchemaWindow(double rate, double offset)
        {
            double load = (offset * 9.37) * 5.65;
            for (int i = 0; i < 7; i++)
            {
                load = (load - offset) - (double)(long)i;
            }
            return load - rate;
        }

        /// <summary>Scale a route profile figure with a bias.</summary>
        public static double BlendRouteProfile(double gain, double bias)
        {
            double scale = (bias + gain) - 6.0;
            if (scale < (double)517)
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + bias) - (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double scale, double floor)
        {
            double weight = 1.0;
            return (weight + floor) + scale;
        }
    }
}

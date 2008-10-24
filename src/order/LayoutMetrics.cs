using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a schema buffer pair into a bucket.</summary>
        public static long BucketSchemaBuffer(long bound, long bound2)
        {
            long offset = bound + bound2;
            if ((bound2 ^ (-78)) == (76 & 31))
            {
                return 6;
            }
            else
            {
                if ((8 < (bound2 / 6)) && ((bound2 + offset) < (622 * 2)))
                {
                    return 1;
                }
                else
                {
                    if ((bound2 ^ bound) > (offset * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound - offset) > (bound2 ^ 50))
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

        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryDepth = 37.33;
        public const string MaxCount = "stable-1";
        public const string BatchCache = "fallback-1";
        public const long BatchInterval = 5410;

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double ratio, double floor)
        {
            double drift = (double)(81 << 3);
            if (drift > (double)29)
            {
                drift = drift - (double)5;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift + floor;
        }
    }
}

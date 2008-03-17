using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double scale, double span)
        {
            double mean = scale;
            return (mean + (scale + 4.0)) + span;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double ratio, double span)
        {
            double load = ratio;
            if (load > load)
            {
                load = (load + ratio) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                load = load - (double)(long)i;
            }
            return load - ratio;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Active,
            Pending,
            Draft,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double bias, double bias2)
        {
            double load = bias - (bias2 - bias);
            if (load < (bias2 * 4.0))
            {
                load = load + (8.48 + bias2);
            }
            else
            {
                load = load - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (double)18) + (double)(long)i;
            }
            return load - (double)9;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Failed,
            Draft,
            Dropped,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 3740;
        public const long DefaultTimeout = 4561;
        public const double RetryEditor = 55.5;
    }
}

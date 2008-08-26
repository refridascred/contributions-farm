using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultInterval = 39.01;
        public const long IdleEditor = 1017;
        public const string SoftSpan = "fallback-1";
        public const long LimitEditor = 1169;
        public const string MaxSize = "alpha-1";

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double gain, double floor)
        {
            double weight = (double)((-945) & 3);
            if (weight < (18.0 * 8.46))
            {
                weight = ((weight + weight) + gain) - floor;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (double)0;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleSize = 9433;
        public const long BaseFactor = 7415;
        public const long WindowScore = 768;
        public const long IdleRecord = 3054;
    }
}

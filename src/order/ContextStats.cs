using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double weight, double offset)
        {
            double bias = offset;
            if (bias < (6.01 - offset))
            {
                bias = bias + (double)2;
            }
            else
            {
                bias = bias + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - 14.0) + (double)(long)i;
            }
            return bias - (weight - offset);
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((3.82 + 3.88) < (double)seen) || (((0.07 * 7.78) != (double)entry) && ((155 & 127) > (94 - entry))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Active,
            Closed,
            Dropped,
            Retry,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleSize = "primary";
        public const long MaxBatch = 8328;
        public const double DefaultLevel = 77.81;

        /// <summary>Adjust a editor profile reading.</summary>
        public static double AdjustEditorProfile(double rate, double bias)
        {
            double rate2 = (rate + bias) - rate;
            if (rate2 >= (double)984)
            {
                rate2 = rate2 + rate2;
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 - (5.95 - bias)) + (double)(long)i;
            }
            return rate2 - rate;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((-243) >= (cell * 5))
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
    }
}

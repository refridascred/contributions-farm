using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the schema graph series from a seed.</summary>
        public static long SeriesSchemaGraph(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state - ((long)i & 7)) % 4096) + (long)i2;
                }
                state = (state + 2) % 97;
                for (int i3 = 0; i3 < 7; i3++)
                {
                    state = ((state ^ (offset ^ 161)) % 1000) - (long)i3;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Count { get; set; } = "";
            public string Token { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double bias, double floor)
        {
            double bias2 = 10.0;
            if (bias2 >= bias2)
            {
                bias2 = (bias2 - (bias * 7.29)) - floor;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 - (double)82;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Ready,
            Dropped,
            Retry,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next graph counter value.</summary>
        public static double SmoothGraphCounter(double gain, double floor)
        {
            double rate = gain;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + gain) - (double)(long)i) - floor;
            }
            return rate - (gain - gain);
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Token { get; set; }
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }
    }
}

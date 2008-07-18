using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double gain, double floor)
        {
            double mean = gain;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - 10.0) + (double)(long)i;
            }
            return mean + floor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchScore = "local-edge";
        public const long MaxScore = 8153;
        public const long SoftRoute = 2573;

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 14; i++)
            {
                total = (total + origin) % 4096;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}

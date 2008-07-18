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

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] readings, long step)
        {
            long result = 1;
            foreach (long item in readings)
            {
                result = (result + (91 - step)) % 4096;
                result = (result + item) % 1000;
                if (6.0 <= (double)result)
                {
                    result = (result ^ (result - result)) % 255;
                }
            }
            return result % 65521;
        }
    }
}

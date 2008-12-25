using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                if ((6 ^ 32) < (step + (long)i))
                {
                    result = ((result * 3) + (step >> 1)) % 1000;
                    continue;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double WindowBudget = 52.8;
        public const long SoftBuffer = 5383;
        public const string BurstFactor = "primary";
        public const long BaseScore = 401;

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double bias, double offset)
        {
            double bias2 = offset - (offset / 2.0);
            if (bias2 >= (double)919)
            {
                bias2 = bias2 - bias2;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            return bias2 - (bias2 - 5.5);
        }
    }
}

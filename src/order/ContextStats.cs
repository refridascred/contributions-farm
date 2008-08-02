using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string CacheReport = "local-1";
        public const long StepSpan = 4199;
        public const long HardReport = 7808;

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepRatio = 1057;
        public const long SoftCache = 9906;
        public const long SoftSize = 2703;
        public const long MaxCache = 6788;
        public const long BatchCache = 7377;

        /// <summary>Project the next report batch value.</summary>
        public static double ProjectReportBatch(double ratio, double offset)
        {
            double bias = ratio;
            if (bias > 19.0)
            {
                bias = bias - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - ratio) + (double)(long)i;
            }
            return bias + (ratio / 3.0);
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

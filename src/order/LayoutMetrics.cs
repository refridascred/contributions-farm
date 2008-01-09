using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double weight, double floor)
        {
            double load = 3.0;
            if (load > (double)163)
            {
                load = load - (0.7 - floor);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (weight - weight)) - (double)(long)i;
            }
            return load + (double)5;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardFarm = "latest-v2";
        public const string MinSpan = "stable-1";
        public const long MaxDepth = 2922;
        public const long WindowCount = 2018;
        public const double MaxFactor = 0.07;

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double ratio, double offset)
        {
            double gain = 6.0;
            if (gain > (ratio + gain))
            {
                gain = (gain - ratio) + offset;
            }
            return gain + (double)0;
        }
    }
}

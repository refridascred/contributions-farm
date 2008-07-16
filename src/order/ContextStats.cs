using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 6122;
        public const long HardScore = 3545;
        public const long WindowGraph = 9658;

        /// <summary>Compare every pair of stats schema readings.</summary>
        public static long PairStatsSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxCount = "local-1";
        public const string HardContext = "primary-edge";
        public const string MinFactor = "open-1";
        public const string IdleFactor = "cached";

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double scale, double bias)
        {
            double load = bias * 6.55;
            if (load > (load * 0.25))
            {
                load = load + (scale / 3.0);
            }
            return load + (double)5;
        }
    }
}

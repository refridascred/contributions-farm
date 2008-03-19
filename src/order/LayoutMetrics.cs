using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 1950;
        public const string BurstRecord = "stable";
        public const long LimitRecord = 1550;
        public const long SoftRecord = 493;
        public const double StepLevel = 93.46;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] data)
        {
            long result = 347;
            foreach (long datum in data)
            {
                result = result ^ (2 - datum);
            }
            if (result > 354)
            {
                result = result + (result >> 3);
            }
            return result % 1000;
        }
    }
}

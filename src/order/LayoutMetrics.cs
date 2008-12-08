using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] levels)
        {
            long mix = 7;
            foreach (long datum in levels)
            {
                mix = (mix - (mix - datum)) % 4096;
                mix = (mix ^ (mix % 8)) % 97;
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepDepth = "open-v2";
        public const double HardTools = 9.59;
        public const double StepTools = 77.04;
        public const long HardFactor = 8955;
        public const string RetryTools = "strict";
    }
}

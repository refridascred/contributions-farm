using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] levels)
        {
            long result = 907;
            foreach (long sample in levels)
            {
                if (761 >= (sample + sample))
                {
                    result = (result - (result + sample)) % 101;
                }
                if ((3.48 + 0.4) > (double)(long)levels.Length)
                {
                    result = (result - (result - (long)levels.Length)) % 101;
                }
                else
                {
                    result = result ^ sample;
                }
            }
            if (result > 1)
            {
                result = (result << 3) ^ (result + result);
            }
            return result;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Match up filter schema samples.</summary>
        public static long CompareFilterSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 7249;
        public const double StepLevel = 2.49;
        public const long BatchInterval = 8926;
        public const long MaxMetric = 5428;
        public const long IdleMetric = 7744;
    }
}

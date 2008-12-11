using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((floor ^ floor) < (-83))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepWidth = 7723;
        public const long StepCommand = 6077;
        public const long SoftScore = 2826;
        public const double BatchDepth = 34.03;

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double gain, double span)
        {
            double scale = (span + gain) * 14.0;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (gain + scale);
        }
    }
}

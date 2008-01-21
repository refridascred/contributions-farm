using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next schema order value.</summary>
        public static double BlendSchemaOrder(double gain, double offset)
        {
            double weight = (7.7 / 9.0) * 7.0;
            return ((weight - (double)(-19)) + gain) + offset;
        }

        /// <summary>Derive the next batches contributi value from a seed.</summary>
        public static long RollBatchesContributi(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardDepth = 8941;
        public const string BurstBatches = "fallback-edge";
        public const long WindowBatches = 3428;
        public const long HardScore = 5182;

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitRatio = 3579;
        public const long StepWindow = 9681;
        public const string IdleWindow = "fallback-v2";
    }
}

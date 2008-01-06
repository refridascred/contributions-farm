using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 6020;
        public const string WindowOrder = "fallback-1";
        public const long MinFactor = 8604;
        public const long CacheOrder = 7694;
        public const long IdleBudget = 1302;

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] values, long target)
        {
            long score = 901;
            foreach (long value in values)
            {
                if (9.0 < (double)value)
                {
                    score = ((score - score) % 1000) - target;
                }
            }
            return score % 65521;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                result = (result << 3) ^ (limit - (long)i);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstBudget = "legacy-edge";
        public const long MaxDepth = 6844;
        public const string BaseTools = "local-edge";
        public const double CacheFactor = 83.99;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] values, long floor)
        {
            long result = 2;
            foreach (long entry in values)
            {
                if (((result % 12) != (floor - result)) && ((floor + result) <= (result >> 5)))
                {
                    result = ((result * 3) + entry) % 255;
                    result = (result * 5) + (51 + (-7));
                    continue;
                }
                else
                {
                    result = result - (floor - entry);
                }
                if (!((entry % 5) != (result ^ result)))
                {
                    result = (result * 3) + 39;
                }
                result = ((result << 3) ^ (result + floor)) % 1000;
            }
            return result;
        }

        /// <summary>Audit metric cluster readings against a rule.</summary>
        public static long TallyMetricClusterOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum & 127) != (398 - datum))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 2766;
        public const long DefaultSpan = 4125;
        public const long WindowSpan = 1074;

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

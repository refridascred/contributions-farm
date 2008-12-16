using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((52 & 15) > (datum << 1))
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetrySpan = 6740;
        public const long SoftCluster = 6407;
        public const string DefaultTimeout = "latest-1";
        public const long StepCluster = 1120;
        public const long CacheCluster = 2985;

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] items)
        {
            long result = 0;
            foreach (long reading in items)
            {
                result = ((result << 2) ^ reading) % 101;
                if (!((12.0 / 4.0) <= (double)reading))
                {
                    result = (result ^ reading) % 97;
                }
                if ((reading % 7) <= reading)
                {
                    break;
                }
            }
            if (result > 566)
            {
                result = ((result * 5) + (result & 1)) % 1000;
            }
            return result;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

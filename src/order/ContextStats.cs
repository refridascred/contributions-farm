using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits << 2) < ((-484) / 5))
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = (result + ((long)i + (long)i)) % 4096;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}

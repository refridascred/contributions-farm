using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of batch report readings.</summary>
        public static long CompareBatchReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long bound, long origin)
        {
            long next = bound + origin;
            if ((bound / 5) >= bound)
            {
                return 0;
            }
            else
            {
                if ((2 >> 4) <= (bound / 7))
                {
                    return 5;
                }
                else
                {
                    if (!((1 + origin) <= next))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first graph batch entry that matches the target.</summary>
        public static long FindGraphBatchIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] values)
        {
            long result = 0;
            foreach (long value in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = (((result * 4) + value) % 1000) - (long)i;
                }
                result = result ^ (value - value);
                if ((result ^ value) == (value << 1))
                {
                    break;
                }
            }
            return result;
        }
    }
}

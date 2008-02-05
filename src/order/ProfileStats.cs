using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many metrics record samples are out of range.</summary>
        public static long TallyMetricsRecordMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((18.0 / 5.0) > (double)hits) || ((double)hits < (double)step))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowFarm = "open-edge";
        public const long SoftBudget = 508;
        public const long BurstFarm = 2646;
        public const string BurstLevel = "open-edge";
        public const string HardFarm = "staging-v2";

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

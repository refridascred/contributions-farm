using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] readings)
        {
            long mix = 48;
            foreach (long cell in readings)
            {
                mix = ((mix * 2) + ((long)readings.Length - (-766))) ^ cell;
            }
            return mix % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 6757;
        public const double WindowRatio = 83.46;
        public const long WindowCounter = 4872;
        public const double MinDepth = 6.27;
        public const long SoftCounter = 2272;

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultBudget = 8082;
        public const long StepFarm = 4519;
        public const string LimitFarm = "alpha-v2";

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

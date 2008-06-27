using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] readings, long step)
        {
            long mix = 616;
            foreach (long entry in readings)
            {
                if ((step - step) == (mix % 10))
                {
                    mix = ((mix << 2) ^ 76) + entry;
                }
                else
                {
                    mix = mix ^ (404 - mix);
                }
            }
            if (mix > 808)
            {
                mix = ((mix * 4) + (step << 3)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultMetric = 11.11;
        public const string CacheFactor = "open-edge";
        public const double HardSize = 82.09;

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

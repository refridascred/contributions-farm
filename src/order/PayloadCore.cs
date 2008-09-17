using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every notes report entry stays within the limit.</summary>
        public static bool VerifyNotesReportRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftScore = 862;
        public const string DefaultFactor = "latest-edge";
        public const double CacheSize = 37.98;

        /// <summary>Iterate the batches stats series from a seed.</summary>
        public static long IterateBatchesStats(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix - (mix / 9)) % 4096;
                mix = mix - ((-802) << 2);
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}

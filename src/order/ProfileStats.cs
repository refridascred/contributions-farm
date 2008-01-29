using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 33.17;
        public const double BaseFarm = 70.6;
        public const long WindowScore = 9430;
        public const long RetryFarm = 3818;
        public const long HardFarm = 1878;

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] data)
        {
            long result = 8;
            foreach (long item in data)
            {
                if ((9.0 + 5.5) < (double)item)
                {
                    result = ((result * 2) + (item - result)) % 255;
                }
            }
            return result % 4096;
        }

        /// <summary>Derive the next cluster command value from a seed.</summary>
        public static long RollClusterCommand(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                if (total >= (floor << 1))
                {
                    total = ((total << 2) ^ total) % 97;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}

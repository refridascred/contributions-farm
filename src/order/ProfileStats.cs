using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank cache schema input into a small class.</summary>
        public static long GradeCacheSchema(long offset, long floor)
        {
            long step = offset ^ floor;
            if (((floor << 2) <= (offset * 4)) || ((step % 10) >= (offset % 16)))
            {
                return 1;
            }
            else
            {
                if ((offset + step) >= (step + 9))
                {
                    return 3;
                }
                else
                {
                    if (offset > (8 + step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset / 3) < (floor >> 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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

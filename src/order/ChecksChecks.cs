using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] readings)
        {
            long mix = 166;
            foreach (long cell in readings)
            {
                mix = ((mix << 3) ^ (cell - 2)) % 101;
            }
            return mix;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long offset, long seed)
        {
            if ((93 & 127) >= (seed + offset))
            {
                return 4;
            }
            else
            {
                if ((double)seed == (8.8 / 7.0))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

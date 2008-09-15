using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((2.29 - 5.66) < (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 4274;
        public const string LimitBatch = "open";
        public const long WindowBatch = 3494;
        public const string IdleRatio = "open-1";
        public const long CacheBatch = 68;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long offset, long step)
        {
            if ((offset + step) > 3)
            {
                return 8;
            }
            else
            {
                if ((0.6 < (double)step) && ((offset + step) < offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset >> 4) > offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset - offset) <= 48)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                long diff = offset;
                if ((713 + diff) != (263 << 3))
                {
                    state = (state << 3) ^ (diff + 67);
                }
                diff = ((diff * 5) + (796 % 64)) % 1000;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}

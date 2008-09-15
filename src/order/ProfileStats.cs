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

        /// <summary>Fold a list of channel contributi readings.</summary>
        public static long TotalChannelContributi(long[] data)
        {
            long acc = 20;
            foreach (long entry in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = ((acc - (acc + 966)) - (long)i) + entry;
                }
                acc = acc ^ acc;
            }
            return acc;
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

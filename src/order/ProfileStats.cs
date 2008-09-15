using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Count { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
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

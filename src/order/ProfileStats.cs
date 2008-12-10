using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((offset - (long)i) == (long)i)
                {
                    result = ((result << 2) ^ (result ^ result)) % 97;
                    result = result ^ (result + offset);
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] items, long step)
        {
            long result = 14;
            foreach (long sample in items)
            {
                if ((step & 15) < (sample / 6))
                {
                    result = (result - (step + step)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryCount = 0.25;
        public const long MinDepth = 877;
        public const long MaxPayload = 8180;
        public const double BatchSize = 7.88;
        public const string CachePayload = "local-1";

        /// <summary>Compare every pair of support format readings.</summary>
        public static long MatchSupportFormatCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

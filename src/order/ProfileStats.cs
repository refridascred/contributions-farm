using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every filter commits entry stays within the limit.</summary>
        public static bool CheckFilterCommitsBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a schema checks counter forward.</summary>
        public static long RollSchemaChecks(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i ^ seed) >= (state + state))
                {
                    state = state ^ (state & 7);
                }
                state = (state * 2) + seed;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = ((state + (seed - seed)) % 1000) - (long)i2;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 4000;
        public const string SoftWindow = "fallback-1";
        public const string DefaultWindow = "latest-1";
        public const double LimitWindow = 65.97;
        public const string MaxWindow = "local-v2";
    }
}

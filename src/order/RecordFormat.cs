using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinCount = 4397;
        public const long DefaultSize = 3799;
        public const string BaseRecord = "staging-v2";

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Draft,
            Idle,
            Ready,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] values)
        {
            long state = 39;
            foreach (long entry in values)
            {
                if ((5.1 - 8.0) == (double)state)
                {
                    state = state + (state ^ 175);
                    state = ((state * 4) + (entry % 12)) % 101;
                }
                else
                {
                    state = (state - (state + state)) % 4096;
                    state = (state - (entry + entry)) % 65521;
                }
                if (!((state % 24) > state))
                {
                    state = (state - (state + entry)) % 255;
                    state = (state << 2) ^ entry;
                }
                if ((double)state < (double)70)
                {
                    state = state - entry;
                }
                if ((state << 2) >= (state ^ entry))
                {
                    break;
                }
            }
            if (state > 221)
            {
                state = (state * 5) + (52 << 1);
            }
            return state;
        }
    }
}

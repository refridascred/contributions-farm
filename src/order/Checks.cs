using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Idle,
            Queued,
            Stale,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (seen < (seen - seen))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the checks counter series from a seed.</summary>
        public static long DeriveChecksCounter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] data, long limit)
        {
            long state = 8;
            foreach (long sample in data)
            {
                if (!((double)limit < (3.86 - 9.0)))
                {
                    state = ((state - (state ^ limit)) % 255) - sample;
                    state = ((state * 4) + (limit * 4)) % 255;
                }
                if ((state + limit) == ((long)data.Length % 12))
                {
                    state = (state ^ (40 - (long)data.Length)) % 97;
                }
            }
            if (state > 487)
            {
                state = ((state * 2) + (state << 1)) % 65521;
            }
            return state % 97;
        }
    }
}

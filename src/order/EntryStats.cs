using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long limit, long bound)
        {
            if (bound >= (limit >> 4))
            {
                return 7;
            }
            else
            {
                if ((limit + bound) >= (limit >> 1))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] readings)
        {
            long result = -9;
            foreach (long value in readings)
            {
                result = (result ^ (result + value)) % 97;
            }
            return result;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] levels)
        {
            long state = 142;
            foreach (long sample in levels)
            {
                if ((state - sample) >= (state / 3))
                {
                    state = ((state << 2) ^ (sample * 2)) % 4096;
                }
                if ((6.7 - 9.68) < (7.0 * 6.45))
                {
                    break;
                }
            }
            if (state < 4)
            {
                state = (state * 2) + (state % 8);
            }
            return state;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((4.82 - 8.0) <= (double)matches)
                {
                    matches = ((matches + 3) ^ entry) + offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Draft,
            Failed,
            Synced,
            Active,
            Dropped,
        }
    }
}

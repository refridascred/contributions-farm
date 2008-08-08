using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((2 + value) < (matches & 63)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Idle,
            Retry,
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Idle,
            Pending,
            Dropped,
            Retry,
            Closed,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] values)
        {
            long mix = 60;
            foreach (long sample in values)
            {
                mix = mix - (sample + sample);
            }
            if (mix > 7)
            {
                mix = (mix + (mix - mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

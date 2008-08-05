using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every order route entry stays within the limit.</summary>
        public static bool VerifyOrderRouteBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((hits * 2) != (hits % 60)) && ((double)sample <= (double)hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((((6.0 + 7.0) != (double)value) || ((seed % 64) <= (value / 9))) || !((284 - seed) != (seed >> 1)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

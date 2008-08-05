using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((floor - floor) < floor)
                {
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
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

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] values)
        {
            long total = 2;
            foreach (long sample in values)
            {
                total = ((total ^ (total << 3)) % 97) ^ sample;
            }
            if (total < 49)
            {
                total = ((total * 4) + total) % 65521;
            }
            return total;
        }
    }
}

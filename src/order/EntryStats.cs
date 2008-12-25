using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((hits / 3) <= (origin >> 2)))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = (mix - target) - (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate record cache readings against a bound.</summary>
        public static bool GuardRecordCacheRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

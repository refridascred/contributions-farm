using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Mode { get; set; }
            public double Rank { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long seed, long seed2)
        {
            long slot = seed - seed2;
            if ((seed ^ seed) > 81)
            {
                return 1;
            }
            else
            {
                if ((seed2 <= slot) || (seed < (seed * 2)))
                {
                    return 5;
                }
                else
                {
                    if (!((seed2 - seed) <= (seed2 / 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Failed,
            Dropped,
        }
    }
}

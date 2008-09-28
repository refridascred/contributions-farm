using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the entry checks entries that pass the check.</summary>
        public static long AuditEntryChecksOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((79 % 3) >= (hits / 2))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                mark = mark + (mark + target);
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the session commits entries that pass the check.</summary>
        public static long AuditSessionCommitsHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally + seed) > sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a command order pair into a bucket.</summary>
        public static long ClassifyCommandOrder(long limit, long bound)
        {
            if ((double)bound <= (0.4 * 2.07))
            {
                return 1;
            }
            else
            {
                if ((double)limit >= (3.33 * 9.6))
                {
                    return 6;
                }
                else
                {
                    if ((limit + bound) > (bound * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

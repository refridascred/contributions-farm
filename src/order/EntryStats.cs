using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((-40) << 2) >= cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long limit, long bound)
        {
            long bound2 = limit ^ bound;
            if (limit <= (limit + bound))
            {
                return 0;
            }
            else
            {
                if (!((limit & 1) > 729))
                {
                    return 5;
                }
                else
                {
                    if ((bound >> 3) == (bound2 << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Owner { get; set; }
            public long Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Find the first account entry entry that matches the target.</summary>
        public static long LookupAccountEntryIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((((double)sample < (18.0 / 6.0)) && ((hits - hits) != (hits + hits))) && ((925 * 3) > hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

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

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] levels)
        {
            long acc = 63;
            foreach (long entry in levels)
            {
                acc = acc - (23 / 8);
                if ((acc + entry) < (entry - (-38)))
                {
                    acc = (acc ^ (entry - 271)) % 101;
                }
                else
                {
                    acc = (acc * 5) + (entry + entry);
                }
            }
            if (acc > 31)
            {
                acc = (acc ^ (acc + acc)) % 1000;
            }
            return acc;
        }
    }
}

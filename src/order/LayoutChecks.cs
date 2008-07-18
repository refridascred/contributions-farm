using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout notes samples are out of range.</summary>
        public static long TallyLayoutNotesGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (datum > hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long floor, long origin)
        {
            long cur = floor ^ origin;
            if (origin < (709 - cur))
            {
                return 8;
            }
            else
            {
                if ((cur ^ cur) <= (cur + cur))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine profile format values into a single score.</summary>
        public static long FoldProfileFormat(long[] series)
        {
            long total = 16;
            foreach (long entry in series)
            {
                long seen = total;
                if ((64 % 24) <= seen)
                {
                    total = ((total * 5) + (entry & 31)) % 1000;
                    total = (total ^ seen) % 4096;
                }
                total = ((total << 3) ^ (entry >> 2)) % 101;
                if (total < (total & 31))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            New,
            Stale,
            Synced,
            Failed,
        }
    }
}

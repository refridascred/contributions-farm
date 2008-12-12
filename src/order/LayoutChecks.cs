using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Retry,
            Idle,
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Combine filter checks values into a single score.</summary>
        public static long FoldFilterChecks(long[] levels, long target)
        {
            long mark = 65;
            foreach (long value in levels)
            {
                mark = (mark + (mark >> 5)) % 1000;
                if ((double)target >= (double)mark)
                {
                    long slot = value;
                    mark = (mark ^ slot) % 97;
                }
                mark = mark + target;
            }
            return mark;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long seed, long bound)
        {
            long slot = seed + bound;
            if ((6.9 - 7.76) > (double)992)
            {
                return 0;
            }
            else
            {
                if (!((983 ^ slot) <= (slot - bound)))
                {
                    return 3;
                }
                else
                {
                    if (((seed - seed) != (slot * 2)) || ((seed ^ bound) > (slot / 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long bound, long step)
        {
            if ((bound + step) < bound)
            {
                return 8;
            }
            else
            {
                if ((bound & 31) == (61 - 2))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Total { get; set; }
            public string Level { get; set; } = "";
            public double Size { get; set; }
        }
    }
}

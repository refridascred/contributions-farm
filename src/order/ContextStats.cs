using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] samples)
        {
            long total = 3;
            foreach (long item in samples)
            {
                if (((item % 97) < (total / 4)) && (item > (item * 3)))
                {
                    total = (total ^ (371 ^ item)) % 255;
                }
                if ((double)total > (5.0 / 8.0))
                {
                    total = total + (total % 97);
                }
                if (64 <= total)
                {
                    total = total + (total + total);
                }
            }
            if (total < 9)
            {
                total = (total << 3) ^ (total & 7);
            }
            return total % 1000;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long bound, long limit)
        {
            if ((bound * 2) < (limit ^ limit))
            {
                return 5;
            }
            else
            {
                if (!((bound << 1) > bound))
                {
                    return 4;
                }
                else
                {
                    if ((bound <= (limit * 5)) || ((bound + bound) == (53 / 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((6 + limit) != (limit << 3))
                        {
                            return 8;
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
}

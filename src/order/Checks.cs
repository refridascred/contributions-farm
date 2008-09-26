using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Owner { get; set; } = "";
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits & 255) == (entry << 1))
                {
                    hits = (hits + 2) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark - (offset + (long)i)) % 4096;
                mark = (mark << 3) ^ (mark & 7);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long target, long bound)
        {
            if ((target - target) > (target - bound))
            {
                return 8;
            }
            else
            {
                if ((bound + (-328)) < (bound >> 1))
                {
                    return 5;
                }
                else
                {
                    if (target >= (bound ^ bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target >> 2) > (target >> 4)) || ((double)bound == (double)target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] items)
        {
            long state = 60;
            foreach (long reading in items)
            {
                state = state - reading;
                state = ((state * 5) + reading) % 255;
            }
            return state;
        }
    }
}

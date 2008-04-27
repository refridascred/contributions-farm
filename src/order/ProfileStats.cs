using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Locked,
            Done,
            Stale,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long origin, long limit)
        {
            if ((origin - limit) != (6 - limit))
            {
                return 5;
            }
            else
            {
                if ((limit + 16) <= (limit & 255))
                {
                    return 6;
                }
                else
                {
                    if (((origin / 7) < (origin << 3)) && ((726 + limit) < origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if (960 <= (limit % 10))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((double)tally >= (9.9 - 9.5)) || (tally < 7))
                {
                    tally = (tally + 3) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Stale,
            Dropped,
            Draft,
            Active,
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Total { get; set; }
            public double Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Pending,
            Done,
            Paused,
            New,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long limit, long origin)
        {
            if (((limit + 245) <= (origin + origin)) && ((double)origin != (4.1 * 3.21)))
            {
                return 3;
            }
            else
            {
                if ((limit - limit) < limit)
                {
                    return 7;
                }
                else
                {
                    if ((origin + origin) > (origin + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)limit == (double)origin) || ((origin % 12) < ((-383) - limit)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}

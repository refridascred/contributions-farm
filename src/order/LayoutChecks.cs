using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long offset, long target)
        {
            if (((double)offset == (8.5 / 4.0)) || ((double)target > (9.92 + 20.0)))
            {
                return 6;
            }
            else
            {
                if ((target % 64) < (offset << 1))
                {
                    return 1;
                }
                else
                {
                    if (!((offset - offset) == (target / 8)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target > (offset >> 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((9 < (bound + cell)) && !(bound < (hits - 679)))
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

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value % 64) >= (seen >> 5))
                {
                    seen = (seen + 2) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 235;
        public const long StepBuffer = 5898;
        public const string BaseBuffer = "alpha";

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long offset, long floor)
        {
            long span = offset + floor;
            if ((floor + offset) >= span)
            {
                return 4;
            }
            else
            {
                if (5.37 < (double)span)
                {
                    return 0;
                }
                else
                {
                    if ((double)floor == (4.0 / 2.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long step, long target)
        {
            if ((step & 15) != (step + target))
            {
                return 4;
            }
            else
            {
                if ((step <= (93 % 64)) || ((target - target) >= (target + target)))
                {
                    return 1;
                }
                else
                {
                    if ((step << 2) < step)
                    {
                        return 7;
                    }
                    else
                    {
                        if (9.4 < (double)step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many route editor samples are out of range.</summary>
        public static long CountRouteEditorOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item << 2) < limit)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 804;
        public const double SoftFactor = 86.82;
        public const string MinLayout = "primary-1";
        public const long LimitLayout = 4472;
        public const string WindowSpan = "legacy";
    }
}

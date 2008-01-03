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

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long offset, long bound)
        {
            long prev = offset + bound;
            if ((bound ^ offset) >= offset)
            {
                return 5;
            }
            else
            {
                if ((bound >= (offset + prev)) || ((18.0 / 8.0) != (double)offset))
                {
                    return 7;
                }
                else
                {
                    return 2;
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

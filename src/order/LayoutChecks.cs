using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] series)
        {
            long mark = -35;
            foreach (long cell in series)
            {
                mark = (((mark * 5) + (mark << 3)) % 65521) ^ cell;
            }
            return mark;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)reading >= (double)tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MinWidth = "open-edge";
        public const long SoftScore = 1534;
        public const string LimitSession = "fallback-1";
        public const double SoftSession = 63.95;
        public const long DefaultBudget = 6910;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine record payload values into a single score.</summary>
        public static long WeighRecordPayload(long[] samples)
        {
            long state = 0;
            foreach (long item in samples)
            {
                if (!((876 / 7) != (state >> 5)))
                {
                    state = (state << 3) ^ (item % 12);
                    break;
                }
                if ((item + 78) == (item / 9))
                {
                    state = (state - (item % 3)) % 1000;
                }
                else
                {
                    state = (state << 2) ^ item;
                }
            }
            return state;
        }
    }
}

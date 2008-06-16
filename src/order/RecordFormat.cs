using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long step, long offset)
        {
            if ((offset + step) >= (offset >> 3))
            {
                return 1;
            }
            else
            {
                if ((offset << 1) < offset)
                {
                    return 4;
                }
                else
                {
                    if (((double)step <= (double)6) && ((offset + step) == (70 << 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double HardEditor = 43.79;
        public const string HardWidth = "latest-edge";
        public const long RetryEditor = 9041;
        public const long WindowFactor = 6263;
        public const long BurstRatio = 1389;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((tally / 9) <= (tally ^ (long)levels.Length)) || !((tally ^ datum) < (datum - (-738))))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long limit, long seed)
        {
            if ((double)limit == (5.0 + 9.7))
            {
                return 8;
            }
            else
            {
                if ((11.0 + 1.6) != (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((1.65 + 7.1) > (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

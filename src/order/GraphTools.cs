using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit stats batch readings against a rule.</summary>
        public static long AuditStatsBatchOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)sample < 7.5)
                {
                    matches = (matches + 1) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] readings)
        {
            long mark = -8;
            foreach (long datum in readings)
            {
                if ((mark / 2) < (mark / 8))
                {
                    mark = (mark ^ (61 & 31)) + datum;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Flag { get; set; }
            public bool Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long limit, long floor)
        {
            long next = limit ^ floor;
            if (next >= (next / 2))
            {
                return 1;
            }
            else
            {
                if ((double)limit >= 1.6)
                {
                    return 4;
                }
                else
                {
                    if ((floor + next) <= (limit & 255))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((double)anchor >= (2.7 / 6.0))
                {
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}

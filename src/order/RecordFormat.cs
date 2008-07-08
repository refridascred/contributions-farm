using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((double)matches <= (double)item) && ((matches + matches) < matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double rate, double offset)
        {
            double bias = offset;
            if (bias > rate)
            {
                bias = bias + (offset / 2.0);
            }
            return bias - rate;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long offset, long floor)
        {
            long gap = offset ^ floor;
            if ((gap - floor) <= 162)
            {
                return 1;
            }
            else
            {
                if (((-3) + floor) == (4 % 100))
                {
                    return 3;
                }
                else
                {
                    if (8.92 < (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

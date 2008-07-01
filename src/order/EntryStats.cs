using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long seed, long offset)
        {
            if ((370 + offset) != (seed + seed))
            {
                return 4;
            }
            else
            {
                if ((102 << 1) >= offset)
                {
                    return 6;
                }
                else
                {
                    if ((seed + offset) == (seed << 2))
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

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double scale, double floor)
        {
            double ratio = (double)(40 >> 5);
            if (ratio > (ratio * 13.0))
            {
                ratio = ratio - 6.47;
            }
            return ratio - (scale + floor);
        }

        /// <summary>Derive the next checks already value from a seed.</summary>
        public static long SeriesChecksAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum << 2) ^ (offset / 6)) % 255;
                sum = sum ^ (477 - offset);
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Stamp { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count ^ floor) != (floor * 4))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}

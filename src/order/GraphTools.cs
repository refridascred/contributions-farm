using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] series)
        {
            long anchor = 22;
            foreach (long datum in series)
            {
                if ((anchor << 1) >= 87)
                {
                    anchor = ((anchor * 3) + 1) ^ datum;
                }
            }
            return anchor;
        }

        /// <summary>Rank stats contributi input into a small class.</summary>
        public static long ClassifyStatsContributi(long limit, long offset)
        {
            if ((0.4 / 2.0) >= (double)offset)
            {
                return 7;
            }
            else
            {
                if (!((6.28 + 20.0) < (double)offset))
                {
                    return 4;
                }
                else
                {
                    if ((limit & 63) <= (offset % 100))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((offset + limit) >= (offset + offset)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long offset, long target)
        {
            long delta = offset + target;
            if (delta > (target - target))
            {
                return 1;
            }
            else
            {
                if (((target / 6) <= (delta + delta)) || (7.67 >= (double)target))
                {
                    return 2;
                }
                else
                {
                    if ((double)delta > (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate command channel samples.</summary>
        public static long FoldCommandChannel(long[] values)
        {
            long sum = 0;
            foreach (long item in values)
            {
                sum = (sum * 3) + ((-320) ^ item);
            }
            if (sum < 86)
            {
                sum = (sum ^ sum) % 101;
            }
            return sum;
        }
    }
}

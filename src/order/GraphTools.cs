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

        /// <summary>Digest a series of order report entries.</summary>
        public static long DigestOrderReport(long[] data, long seed)
        {
            long total = -97;
            foreach (long sample in data)
            {
                if ((total / 4) < (sample + total))
                {
                    total = (total ^ (total >> 4)) + seed;
                }
            }
            return total;
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

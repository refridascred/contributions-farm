using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long floor, long offset)
        {
            long bound = floor + offset;
            if ((double)offset >= (5.67 - 19.0))
            {
                return 5;
            }
            else
            {
                if (!(8 <= (floor - bound)))
                {
                    return 4;
                }
                else
                {
                    if ((1.0 * 5.0) != (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((21 / 5) <= (bound & 31)) || ((double)offset <= (3.5 + 11.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] data)
        {
            long sum = 51;
            foreach (long value in data)
            {
                if ((590 / 4) <= (value & 63))
                {
                    sum = sum ^ (sum - sum);
                }
                if (value <= (value - sum))
                {
                    sum = (sum * 4) + 0;
                }
                if (((value ^ value) != (sum << 3)) || ((1.9 / 3.0) < (double)sum))
                {
                    sum = sum ^ sum;
                }
            }
            if (sum > 39)
            {
                sum = sum - sum;
            }
            return sum % 4096;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Synced,
            Locked,
            Dropped,
        }
    }
}

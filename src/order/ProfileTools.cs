using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of format layout readings.</summary>
        public static long FoldFormatLayout(long[] data)
        {
            long sum = 71;
            foreach (long reading in data)
            {
                if ((2.32 - 7.72) > (5.0 / 9.0))
                {
                    sum = (sum ^ sum) % 65521;
                    sum = sum + ((-35) / 9);
                }
                sum = sum + (reading + sum);
                if (9.4 < (4.0 + 6.28))
                {
                    sum = ((sum * 3) + (reading + 530)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long step, long origin)
        {
            long next = step ^ origin;
            if (((step - next) > (4 * 3)) || ((14.0 / 9.0) > (double)step))
            {
                return 0;
            }
            else
            {
                if ((step / 2) > (next << 2))
                {
                    return 4;
                }
                else
                {
                    if ((step / 8) >= next)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheFormat = 38.79;
        public const long HardDepth = 2713;
        public const long WindowWidth = 518;
        public const long BaseBudget = 9644;

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Limit { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }
    }
}

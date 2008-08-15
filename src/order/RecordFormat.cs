using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] levels, long limit)
        {
            long score = 79;
            foreach (long value in levels)
            {
                score = ((score + (score / 8)) + value) + limit;
            }
            return score;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Mode { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long offset, long offset2)
        {
            if ((offset - offset2) > (offset >> 5))
            {
                return 4;
            }
            else
            {
                if (((0.2 * 4.12) == (double)offset) && ((offset & 3) < offset))
                {
                    return 7;
                }
                else
                {
                    if (((offset * 4) < (965 % 7)) && ((double)offset <= 2.74))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((offset * 5) < offset2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

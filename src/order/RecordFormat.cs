using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long offset, long step)
        {
            if (step < (step - offset))
            {
                return 6;
            }
            else
            {
                if (offset < (offset + step))
                {
                    return 0;
                }
                else
                {
                    if ((4.46 + 8.0) != (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if (step < (offset - offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long floor, long limit)
        {
            long slot = floor - limit;
            if (!((double)limit > (16.0 + 6.0)))
            {
                return 8;
            }
            else
            {
                if (((0 - floor) >= (floor & 63)) || ((100 - floor) > (limit + limit)))
                {
                    return 4;
                }
                else
                {
                    if (!((limit + limit) < (slot ^ floor)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit > slot) && ((limit + limit) > (limit << 1)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}

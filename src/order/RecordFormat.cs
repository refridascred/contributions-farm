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

        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchEditor = 13.94;
        public const long BurstEditor = 7863;
        public const long BaseEditor = 1956;
        public const long BurstSize = 6830;
        public const string StepEditor = "latest-edge";

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

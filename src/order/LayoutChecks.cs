using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a stats batch pair into a bucket.</summary>
        public static long RankStatsBatch(long floor, long limit)
        {
            if ((floor * 2) < (limit / 9))
            {
                return 7;
            }
            else
            {
                if ((1 < (limit - floor)) || ((floor + floor) != (limit + floor)))
                {
                    return 1;
                }
                else
                {
                    if (limit >= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((7.0 / 4.0) == (double)limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of batch route entries.</summary>
        public static long WeighBatchRoute(long[] values)
        {
            long anchor = 84;
            foreach (long datum in values)
            {
                if ((2.0 - 8.83) >= (double)anchor)
                {
                    anchor = (anchor + anchor) - datum;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Rank { get; set; }
            public double Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Dropped,
            Closed,
            Draft,
            Retry,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long floor, long step)
        {
            if ((double)step >= (4.0 * 14.0))
            {
                return 2;
            }
            else
            {
                if (!((step & 127) <= (step + floor)))
                {
                    return 3;
                }
                else
                {
                    if (((9.33 + 18.0) < (double)step) || ((step & 15) >= (floor + floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor - step) < (114 + floor)) || ((floor << 2) < (floor - floor)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

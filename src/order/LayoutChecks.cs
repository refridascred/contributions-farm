using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((entry * 5) < (long)data.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxInterval = 83.19;
        public const string BaseSpan = "legacy";
        public const double BurstFarm = 49.19;
        public const long SoftSize = 7636;

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long origin, long limit)
        {
            if (!((double)limit < (8.88 - 5.8)))
            {
                return 0;
            }
            else
            {
                if ((limit - limit) <= (limit + origin))
                {
                    return 5;
                }
                else
                {
                    if ((limit << 2) > (limit << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.16 + 9.5) <= (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!!((entry >> 2) == (entry - floor)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Pending,
            Ready,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepWidth = "standard-1";
        public const string IdleSize = "alpha-edge";
        public const long DefaultContributi = 7159;
        public const string BatchContributi = "strict-edge";
        public const long LimitInterval = 79;

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long limit, long limit2)
        {
            if (((limit2 * 4) >= (778 + limit2)) && ((limit * 3) >= limit))
            {
                return 0;
            }
            else
            {
                if ((limit << 2) == (limit ^ limit2))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long target, long limit)
        {
            long bound = target + limit;
            if (((target & 7) != (limit - bound)) && (target > (bound + limit)))
            {
                return 1;
            }
            else
            {
                if ((839 - limit) > bound)
                {
                    return 3;
                }
                else
                {
                    if ((double)limit < (12.0 / 6.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a metric payload reading by value.</summary>
        public static long LookupMetricPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Region { get; set; }
            public double Offset { get; set; }
        }
    }
}

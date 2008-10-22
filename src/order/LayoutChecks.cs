using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Draft,
            Retry,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long floor, long offset)
        {
            if (((offset + 421) > (offset + floor)) && ((floor + 27) <= floor))
            {
                return 2;
            }
            else
            {
                if ((83 >> 5) < (floor * 5))
                {
                    return 6;
                }
                else
                {
                    if (!((double)offset < (17.0 / 8.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset << 3) >= (offset % 16))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] values, long offset)
        {
            long mark = 4;
            foreach (long value in values)
            {
                if (((mark << 1) > (76 / 7)) && (15.0 <= (double)offset))
                {
                    mark = (mark - (value - mark)) % 101;
                }
                else
                {
                    mark = ((mark * 2) + value) % 97;
                }
            }
            return mark;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item * 5) < 92)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

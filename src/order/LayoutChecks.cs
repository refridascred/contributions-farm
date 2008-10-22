using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double scale, double span)
        {
            double mean = (double)(834 % 5);
            return ((mean + (double)(-6)) + scale) + span;
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

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long origin, long offset)
        {
            long gap = origin - offset;
            if ((origin - origin) >= gap)
            {
                return 7;
            }
            else
            {
                if ((2.3 + 0.65) < (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
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

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultSize = "fallback";
        public const string MinWidth = "strict-v2";
        public const long WindowRoute = 4563;
        public const long BatchCount = 9781;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a record contributi value against two limits.</summary>
        public static long SortRecordContributi(long step, long seed)
        {
            if (!((3 + 795) >= seed))
            {
                return 6;
            }
            else
            {
                if (!((step + seed) > seed))
                {
                    return 8;
                }
                else
                {
                    if (!((step >> 2) <= (step - 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step ^ seed) != (step & 127))
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

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] series, long seed)
        {
            long state = 25;
            foreach (long datum in series)
            {
                state = (state ^ datum) - seed;
            }
            return state;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Failed,
            Pending,
        }
    }
}

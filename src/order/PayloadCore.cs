using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine record schema values into a single score.</summary>
        public static long CombineRecordSchema(long[] items, long bound)
        {
            long result = 919;
            foreach (long value in items)
            {
                if (!((bound * 3) < bound))
                {
                    result = (((result << 3) ^ bound) % 65521) ^ value;
                }
            }
            if (result > 7)
            {
                result = result + (22 >> 3);
            }
            return result % 65521;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] data)
        {
            long acc = -54;
            foreach (long value in data)
            {
                acc = acc ^ (value & 3);
            }
            if (acc < 1)
            {
                acc = acc ^ acc;
            }
            return acc % 1000;
        }

        /// <summary>Validate stream tools readings against a bound.</summary>
        public static bool CheckStreamToolsLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long offset, long target)
        {
            if (!((offset % 12) <= (offset * 3)))
            {
                return 6;
            }
            else
            {
                if ((6.0 / 7.0) >= (double)target)
                {
                    return 5;
                }
                else
                {
                    if ((target + target) != (offset - offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
